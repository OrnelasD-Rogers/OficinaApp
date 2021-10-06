using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Business;
using Business.Faturamento;

namespace View
{
    public partial class FormItens : Form
    {
        MetodosDataGrid metodosDataGrid = new MetodosDataGrid();
        public FormAparelho frmAparelho { get; set; }
        public Vw_AparelhoInfo Aparelho { get; set; }
        Produtos prodSelecionado = new Produtos();
        //Produtos no estoque
        private List<Produtos> ProdutosList { get; set; } = new List<Produtos>();
        //Lista de produtos já atribuidos ao aparelho
        private List<Produtos> ItensList { get; set; } = new List<Produtos>();

        FormAparelho formAparelho;

        int idAparelho;
        int indexProd = 0;

        //Adiciona Itens
        public FormItens(FormAparelho formAparelho, int idAparelho)
        {
            InitializeComponent();
            this.idAparelho = idAparelho;
            this.formAparelho = formAparelho;
            Inicializacao();
        }

        //Edita Itens
        public FormItens(FormAparelho formAparelho, List<Produtos> itens, int idAparelho)
        {
            InitializeComponent();
            this.idAparelho = idAparelho;
            this.formAparelho = formAparelho;
            ItensList = itens;
            EdicaoItens(ItensList);
        }


        private void EdicaoItens(List<Produtos> produtos)
        {
            Inicializacao();
            metodosDataGrid.FillDataGrid(dgItens, produtos);
        }

        private void Inicializacao()
        {
            ProdutosList.Add(new Produtos
            {
                IdProduto = 9999,
                Produto = "Mão de Obra",
                ValorVenda = 0.00,
                Estoque = 1
            });
            ProdutosList.AddRange(MetodosBd.GetProdutosDbVendasOficina());
            metodosDataGrid.FillDataGrid(dgProdutos, ProdutosList);
        }

        //Adiciona itens a lista ItensList e preenche o datagrid dgItens
        private void AddListaGridItens(DataGridView dataGrid, Produtos prod)
        {
            ItensList.Add(prod);
            metodosDataGrid.FillDataGrid(dgItens, ItensList);
        }

        //Remove itens da lista ItensList e preenche o datagrid dgItens
        private void RemoveListaGridItens(DataGridView dataGrid, Produtos prod)
        {
            ItensList.Remove(prod);
            metodosDataGrid.FillDataGrid(dgItens, ItensList);
        }

        private void EditaEstoque(int qtdAtual, Produtos prod)
        {
            Produtos item = new Produtos
            {
                IdProduto = prod.IdProduto,
                Quantidade = prod.Quantidade
            };
            //Se tiver colocado uma quantidade maior na edicao
            if (item.Quantidade > qtdAtual)
            {
                item.Quantidade = item.Quantidade - qtdAtual;
                MetodosBd.SubtractProdutoEstoque(item);
            }
            else
            {
                item.Quantidade = qtdAtual - item.Quantidade;
                MetodosBd.AddProdutoEstoque(item);
            }
        }

        //--------------------------------------- Metodos DataGrid --------------------------//


        private void dgProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProdutos.Rows.Count > 0)
            {
                indexProd = 0;
                prodSelecionado = (Produtos)dgProdutos.SelectedRows[0].DataBoundItem;
                indexProd = dgProdutos.SelectedRows[0].Index;
                if (ItensList.Where(x => x.IdProduto == prodSelecionado.IdProduto).Select(x => x).Any() == false)
                {
                    switch (prodSelecionado.IdProduto)
                    {
                        //Caso seja mão de obra
                        case 9999:
                            pnAddMaoDeObra.Location = pnAddItem.Location;
                            pnAddMaoDeObra.Show();
                            break;
                        default:
                            nudQtd.Value = 1;
                            pnAddItem.Show();
                            break;
                    }
                }
                else
                {
                    formAparelho.ChamaMessageBoxOk("Produto já Adicionado!");
                }


            }
        }

        private void dgProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                e.Value = Convert.ToDouble(e.Value).ToString("C2");
            }
        }

        private void dgItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 4)
            {
                e.Value = Convert.ToDouble(e.Value).ToString("C2");
            }
        }

        //-------------------------------------------  Eventos Botões  ----------------------------------------//

        private void btnAceitarQTD_Click(object sender, EventArgs e)
        {
            decimal qtd = Convert.ToDecimal(prodSelecionado.Quantidade);
            //Se qtd > 0, Então o produto está sendo Editado
            if (qtd > 0)
            {
                int qtdAtual = ItensList[indexProd].Quantidade;
                ItensList[indexProd].Quantidade = Convert.ToInt32(nudQtd.Value);
                ItensList[indexProd].CalculcaSubTotal();
                //Se o produto tiver um IdItem != 0, então é editado sua quantidade no banco de dados
                try
                {
                    MetodosBd.UpdateQuantidadeItem(ItensList[indexProd]);
                    EditaEstoque(qtdAtual, ItensList[indexProd]);
                }
                catch (Exception) { }
                //ItensList.Remove(ItensList[indexProd]);
                // ItensList.Add(ItensList[indexProd]);
                metodosDataGrid.FillDataGrid(dgItens, ItensList);
                pnAddItem.Hide();

            }
            //Adiciona Novo Produto
            else
            {

                int qtdAdicionada = Convert.ToInt32(nudQtd.Value);
                if (qtdAdicionada <= prodSelecionado.Estoque)
                {
                    Produtos Item = new Produtos
                    {
                        IdProduto = prodSelecionado.IdProduto,
                        Produto = prodSelecionado.Produto,
                        ValorVenda = prodSelecionado.ValorVenda,
                        Estoque = prodSelecionado.Estoque,
                        Quantidade = qtdAdicionada
                    };
                    Item.CalculcaSubTotal();
                    AddListaGridItens(dgItens, Item);
                    pnAddItem.Hide();
                    dgItens.ResumeLayout();
                }
                else
                {
                    formAparelho.ChamaMessageBoxOk($"Não possuimos {qtdAdicionada} un. do Item : {prodSelecionado.Produto}. \nPossuimos {prodSelecionado.Estoque} un. em Estoque");
                }

            }

        }

        private void btnFechaPnAddItem_Click(object sender, EventArgs e)
        {
            pnAddItem.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if (dgItens.Rows.Count > 0)
            {
                Produtos item = (Produtos)dgItens.SelectedRows[0].DataBoundItem;
                if (item.Produto != "Adiantamento" && item.Produto != "Pagamento")
                {
                    RemoveListaGridItens(dgItens, item);
                    //Se o IdItem for != 0, então ele é excluido do bando de dados
                    try
                    {
                        MetodosBd.DeleteItem(item.IdItem);
                    }
                    catch (Exception) { }
                }

            }
        }

        private void btnFechaPnAddMaoDeObra_Click(object sender, EventArgs e)
        {
            pnAddMaoDeObra.Hide();
        }

        private void btnAceitarMDO_Click(object sender, EventArgs e)
        {
            //Edita valor mão de obra
            if (ItensList.Count > 0 && ItensList[indexProd].Produto == "Mão de Obra")
            {
                ItensList[indexProd].ValorVenda = Convert.ToDouble(tbMaoDeObra.Text.Replace("R$ ", ""));
                ItensList[indexProd].CalculcaSubTotal();
                metodosDataGrid.FillDataGrid(dgItens, ItensList);
                pnAddMaoDeObra.Hide();

            }
            //Adiciona nova mão de obra
            else
            {
                double MaoDeObra = Convert.ToDouble(tbMaoDeObra.Text.Replace("R$ ", ""));
                Produtos Item = new Produtos
                {
                    IdProduto = prodSelecionado.IdProduto,
                    Produto = prodSelecionado.Produto,
                    ValorVenda = MaoDeObra,
                    Quantidade = 1,
                    SubTotal = MaoDeObra
                };
                AddListaGridItens(dgItens, Item);
            }

            pnAddMaoDeObra.Hide();
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            if (dgItens.Rows.Count > 0)
            {
                indexProd = 0;
                prodSelecionado = (Produtos)dgItens.SelectedRows[0].DataBoundItem;
                indexProd = dgItens.SelectedRows[0].Index;
                switch (prodSelecionado.IdProduto)
                {
                    //Caso seja mão de obra
                    case 9999:
                        pnAddMaoDeObra.Location = pnAddItem.Location;
                        tbMaoDeObra.Text = ItensList[indexProd].ValorVenda.ToString("C2");
                        pnAddMaoDeObra.Show();
                        break;
                    //Caso seja um Adiantamento(IdItem = 8888) não faz nada
                    case 8888:
                        break;
                    //Caso seja um Pagamento(IdItem = 1010) não faz nada
                    case 1010:
                        break;
                    default:
                        nudQtd.Value = prodSelecionado.Quantidade;
                        pnAddItem.Show();
                        break;
                }
            }
        }

        private void btnSalvarLista_Click(object sender, EventArgs e)
        {
            
            FaturarItens faturarItens = new FaturarItens(ItensList);
            List<Produtos> produtos2Bd = new List<Produtos>();
            Produtos maoDeObra = new Produtos();

            //Atualiza Mão de Obra caso já exista alguma adicionada(IdItem != 0)
            maoDeObra = faturarItens.UpdateMaoDeObra();
            if (maoDeObra != null)
            {
                MetodosBd.UpdateMaoDeObra(maoDeObra);
            }

            //Faz a Seleção dos novos itens que irão apra o Bd
            produtos2Bd = faturarItens.Itens2Bd();
            //Se a Lista.Count > 0, Adiciona os itens ao Bd
            if (produtos2Bd.Count > 0)
            {
                MetodosBd.InsertItens(produtos2Bd, idAparelho);
                formAparelho.ChamaMessageBoxOk("Produtos Adicionados");
            }

            
            formAparelho.Inicializacao();
            this.Close();

        }
    }
}
