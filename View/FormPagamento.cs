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
using Business.Faturamento;
using Business;

namespace View
{
    public partial class FormPagamento : Form
    {
        Vw_AparelhoInfo aparelhoInfo;
        FormAparelho formAparelho;
        public FormPagamento(FormAparelho formAparelho, Vw_AparelhoInfo aparelhoInfo)
        {
            InitializeComponent();
            this.aparelhoInfo = aparelhoInfo;
            this.formAparelho = formAparelho;
            this.Name = "FormAdiantamento";
            InicializarAdiantamento();
        }

        public FormPagamento(FormAparelho formAparelho, Vw_AparelhoInfo aparelhoInfo, double valorAPagar)
        {
            InitializeComponent();
            this.aparelhoInfo = aparelhoInfo;
            this.formAparelho = formAparelho;
            InicializarPagamento(valorAPagar);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InicializarPagamento(double valorApagar)
        {
            switch (aparelhoInfo.Estado)
            {
                case Estado.NAP:
                    cbTipoSaida.Items.Clear();
                    cbTipoSaida.Items.AddRange(new string[] { "NAP_Entregue", "Descarte" });
                    cbTipoPag.Items.Add("Nenhum");
                    break;
                
                case Estado.Aprovado:
                    if (valorApagar == 0)
                    {
                        cbTipoPag.Items.Clear();
                        cbTipoPag.Items.Add("Nenhum");
                        cbTipoPag.SelectedIndex = 0;
                        cbTipoPag.Enabled = false;
                    }
                    tbValor.Text = valorApagar.ToString("C2");
                    tbValor.Enabled = false;
                    cbTipoSaida.Items.Clear();
                    cbTipoSaida.Items.AddRange(new string[] { "APV_Entregue" });
                    cbTipoSaida.SelectedIndex = 0;
                    cbTipoSaida.Enabled = false;
                    break;  

            }
            pnParcelas.Hide();
            pnTipoSaida.Show();
        }

        private void InicializarAdiantamento()
        {
            pnParcelas.Hide();
            pnTipoSaida.Hide();
        }

        private double ValString2Double(string valor)
        {
            try
            {
                return Convert.ToDouble(valor.Trim().Replace("R$", "").Replace(" ", "").Replace("  ", ""));
            }
            catch (Exception)
            {

                return 0;
            }
        }
        private Estado SelecionaEstado(string estado)
        {
            Estado es = new Estado();
            switch (estado)
            {
                case "APV_Entregue":
                    es = Estado.Entregue;
                    break;
                case "NAP_Entregue":
                    es = Estado.NAP_Entregue;
                    break;
                case "Descarte":
                    es = Estado.NAP_Descarte;
                    break;                
            }
            return es;
        }

        private void TipoPagamento(Pagamentos pagamento)
        {
            FaturarPagamento faturar = new FaturarPagamento();

            //Caso seja um pagamento Parcelado
            if (cbTipoPag.SelectedIndex == 1 && nudParcelas.Value > 1)
            {
                faturar.InsertPagamentoParcelado(aparelhoInfo.IdAparelho, pagamento, Convert.ToInt32(nudParcelas.Value));
            }
            //Pagamento normal
            else
            {
                faturar.InsertPagamento(aparelhoInfo.IdAparelho, pagamento);
            }
        }


        private void FinalizarPagamento(Vw_AparelhoInfo aparelhoInfo, Pagamentos novoPag)
        {
            switch (aparelhoInfo.Estado)
            {
                case Estado.Aprovado:
                    if (novoPag.ValidaPagamento(cbTipoPag, cbTipoSaida, ep))
                    {
                        Produtos pagamento = new Produtos
                        {
                            IdProduto = 1010,
                            Produto = "Pagamento",
                            ValorVenda = ValString2Double(tbValor.Text),
                            Quantidade = 1
                        };
                        Estado estado = SelecionaEstado(cbTipoSaida.Text);
                        TipoPagamento(novoPag);
                        MetodosBd.UpdateEstadoAparelho(aparelhoInfo.IdAparelho, DateTime.Now, estado);
                        MetodosBd.InsertItem(pagamento, aparelhoInfo.IdAparelho);
                        formAparelho.ChamaMessageBoxOk("Pagamento e saida do Aparelho Finalizados");
                        formAparelho.Inicializacao();
                        this.Close();
                    }
                    break;
                case Estado.NAP:
                    if (novoPag.ValidaNAP(cbTipoSaida, ep))
                    {
                        Produtos pagamento = new Produtos
                        {
                            IdProduto = 1010,
                            Produto = "Pagamento",
                            ValorVenda = ValString2Double(tbValor.Text),
                            Quantidade = 1
                        };
                        Estado estado = SelecionaEstado(cbTipoSaida.Text);
                        TipoPagamento(novoPag);
                        MetodosBd.UpdateEstadoAparelho(aparelhoInfo.IdAparelho, DateTime.Now, estado);
                        MetodosBd.InsertItem(pagamento, aparelhoInfo.IdAparelho);
                        formAparelho.ChamaMessageBoxOk("Pagamento e saida do Aparelho Finalizados");
                        formAparelho.Inicializacao();
                        this.Close();
                    }
                    break;
            }
        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbValor_Leave(object sender, EventArgs e)
        {
            double valor = ValString2Double(tbValor.Text);
            tbValor.Text = valor.ToString("C2");
        }

        private void FormPagamento_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Pagamentos novoPag = new Pagamentos
            {
                Categoria = "Servicos",
                Valor = ValString2Double(tbValor.Text),
                TipoPag = cbTipoPag.Text,
                DataPag = DateTime.Now
            };

            switch (this.Name)
            {
                case "FormAdiantamento":
                    if (novoPag.ValidaAdiantamento(tbValor, cbTipoPag, ep))
                    {
                        Produtos adiantamento = new Produtos
                        {
                            IdProduto = 8888,
                            Produto = "Adiantamento",
                            ValorVenda = ValString2Double(tbValor.Text),
                            Quantidade = 1
                        };
                        MetodosBd.InsertItem(adiantamento, aparelhoInfo.IdAparelho);
                        TipoPagamento(novoPag);
                        formAparelho.ChamaMessageBoxOk("Pagamento Adiantado Finalizado!");
                        formAparelho.Inicializacao();
                        this.Close();
                    }
                    break;
                default:
                    FinalizarPagamento(aparelhoInfo, novoPag);                    
                    break;
            }
                    
        }


        private void cbTipoPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTipoPag.SelectedIndex)
            {
                case 1:
                    pnParcelas.Show();
                    break;
                default:
                    pnParcelas.Hide();
                    break;
            }
        }
    }
}
