using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Business;
using Entities;

namespace View
{
    public class MetodosGridVwP : MetodosDataGrid
    {
        string ultimaCol { get; set; }

        public void ConfiguraGridPrincipal(DataGridView dataGrid)
        {
            SetDoubleBufferingOn(dataGrid);
            dataGrid.AutoGenerateColumns = false;
            dataGrid.DefaultCellStyle.Font = new Font("Ebrima", 10);
            dataGrid.DefaultCellStyle.ForeColor = Color.Black;
            dataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;   
        }



        public void PesquisarVw_GridPrincipal(DataGridView dataGrid, string search)
        {
            search = search.Trim();
            //Executa se existir apenas numeros na string
            if (search.All(char.IsDigit) && search.Length > 0)
            {
                if (search.Length >= 8)
                {
                    //Se a string for um CPF válido, então é feito a pesquisa pelo Cpf do cliente no Banco
                    if (Validacao.CpfValido(search))
                    {
                       FillDataGrid(dataGrid, MetodosBd.GetVw_GridPrincipalByCpf(search));
                    }
                    //Se não é feito a pesquisa pelo numero de telefone
                    else
                    {
                        FillDataGrid(dataGrid, MetodosBd.GetVw_GridPrincipalByTel(search));
                    }                                           
                }
                //Se o tamanho da string for menor que 8 digitos, então é feita a pesquisa pelo Id do Aparelho
                else
                {
                    int idAp = Convert.ToInt32(search);
                    FillDataGrid(dataGrid, MetodosBd.GetToGridPrincipalByIdAp(idAp));
                }
            }  
            //Se for um nome é pesquisado então pelo nome do cliente no Banco
            if (search.Replace(" ", "").All(char.IsLetter))
            {
                FillDataGrid(dataGrid, MetodosBd.GetVw_GridPrincipalByName(search));
            }
        }

        public void PesquisarCliente(DataGridView dataGrid, string search)
        {
            search = search.Trim();
            //Executa se existir apenas numeros na string
            if (search.All(char.IsDigit) && search.Length > 0)
            {
                if (search.Length >= 8)
                {
                    //Se a string for um CPF válido, então é feito a pesquisa pelo Cpf do cliente no Banco
                    if (Validacao.CpfValido(search))
                    {
                        FillDataGrid(dataGrid, MetodosBd.GetClienteByCpf(search));
                    }
                    //Se não é feito a pesquisa pelo numero de telefone
                    else
                    {
                        FillDataGrid(dataGrid, MetodosBd.GetClienteByNumero(search));
                    }
                }
                //Se o tamanho da string for menor que 8 digitos, então é feita a pesquisa pelo Id do Cliente
                else
                {
                    int idAp = Convert.ToInt32(search);
                    FillDataGrid(dataGrid, MetodosBd.GetClienteById(idAp));
                }
            }
            //Se for um nome é pesquisado então pelo nome do cliente no Banco
            if (search.Replace(" ", "").All(char.IsLetter))
            {
                FillDataGrid(dataGrid, MetodosBd.GetClienteByNome(search));
            }
        }


        public void Ordenar(DataGridView dataGrid, int columIndex)
        {
            DataGridViewColumn column = dataGrid.Columns[columIndex];
            List<Vw_GridPrincipal> auxList = new List<Vw_GridPrincipal>();
                
            switch (column.HeaderText)
            {
                case "Entrada":
                    if (ultimaCol == "Entrada")
                    {
                        auxList = (List<Vw_GridPrincipal>)dataGrid.DataSource;
                        dataGrid.DataSource = auxList.OrderByDescending(d => d.Entrada).ToList();
                        dataGrid.Update();
                        dataGrid.Refresh();
                        ultimaCol = string.Empty;
                    }
                    else
                    {
                        auxList = (List<Vw_GridPrincipal>)dataGrid.DataSource;
                        dataGrid.DataSource = auxList.OrderBy(d => d.Entrada).ToList();
                        dataGrid.Update();
                        dataGrid.Refresh();
                        ultimaCol = "Entrada";
                    }
                    break;

                case "Saida":
                    if (ultimaCol == "Saida")
                    {
                        auxList = (List<Vw_GridPrincipal>)dataGrid.DataSource;
                        dataGrid.DataSource = auxList.OrderByDescending(s => s.Saida).ToList();
                        dataGrid.Update();
                        dataGrid.Refresh();
                        ultimaCol = string.Empty;
                    }
                    else
                    {
                        auxList = (List<Vw_GridPrincipal>)dataGrid.DataSource;
                        dataGrid.DataSource = auxList.OrderBy(s => s.Saida).ToList();
                        dataGrid.Update();
                        dataGrid.Refresh();
                        ultimaCol = "Saida";
                    }
                    break;

                case "Status":
                    if (ultimaCol == "Status")
                    {
                        auxList = (List<Vw_GridPrincipal>)dataGrid.DataSource;
                        dataGrid.DataSource = auxList.OrderByDescending(s => s.Estado).ToList();
                        dataGrid.Update();
                        dataGrid.Refresh();
                        ultimaCol = string.Empty;
                    }
                    else
                    {
                        auxList = (List<Vw_GridPrincipal>)dataGrid.DataSource;
                        dataGrid.DataSource = auxList.OrderBy(s => s.Estado).ToList();
                        dataGrid.Update();
                        dataGrid.Refresh();
                        ultimaCol = "Status";
                    }
                    break;
            }
        }

        public void RowPrePainting(DataGridView dataGrid, DataGridViewRowPrePaintEventArgs e, int cellRev, int cellUrg)
        {
            if (Convert.ToBoolean(dataGrid.Rows[e.RowIndex].Cells[cellRev].Value) == true)
            {
                dataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
            }
            if (Convert.ToBoolean(dataGrid.Rows[e.RowIndex].Cells[cellUrg].Value) == true)
            {
                dataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        public void FormataTelefone_CellFormatting(DataGridView dataGrid, int columTel, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == columTel && e.RowIndex != dataGrid.NewRowIndex && e.Value != null)
            {
                int valor = e.Value.ToString().Count();
                if (valor == 10)
                {
                    e.Value = string.Format("{0:(##) ####-####}", Convert.ToInt64(e.Value));
                }
                if (valor == 11)
                {
                    e.Value = string.Format("{0:(##) #####-####}", Convert.ToInt64(e.Value));
                }
            }
        }

    }
}
