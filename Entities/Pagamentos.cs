using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Pagamentos : Validacao
    {
        public int IdPagamento { get; set; }
        public string Categoria { get; set; }
        public double Valor { get; set; }
        public string TipoPag { get; set; }
        public DateTime DataPag { get; set; }

        public bool ValidaAdiantamento(TextBox tbValor, ComboBox cbTipoPag, ErrorProvider ep)
        {
            ValidaValorADiantamento(tbValor, ep);
            ValidaTipoPag(cbTipoPag, ep);
            return ValidaObj();
        }

        public bool ValidaPagamento(ComboBox cbTipoPag, ComboBox cbTipoSaida, ErrorProvider ep)
        {
            ValidaTipoPag(cbTipoPag, ep);
            ValidaComboBox(cbTipoSaida, ep);
            return ValidaObj();
        }

        public bool ValidaNAP(ComboBox cbTipoSaida, ErrorProvider ep)
        {
            ValidaComboBox(cbTipoSaida, ep);
            return ValidaObj();
        }

        private void ValidaValorADiantamento(TextBox tbValor, ErrorProvider ep)
        {
            if (this.Valor == 0)
            {
                ep.SetError(tbValor, "Entre com o Valor a Ser pago!");
                erros.Add(false);
            }
            else
            {
                ep.SetError(tbValor, "");
            }
        }

        private void ValidaTipoPag(ComboBox cbTipoPag, ErrorProvider ep)
        {
            if (this.TipoPag == string.Empty)
            {
                ep.SetError(cbTipoPag, "Selecione o tipo do pagamento");
                erros.Add(false);
            }
            else
            {
                ep.SetError(cbTipoPag, "");
            }
        }

        private void ValidaComboBox(ComboBox cbTipoSaida, ErrorProvider ep)
        {
            if (cbTipoSaida.Text == null)
            {
                ep.SetError(cbTipoSaida, "Selecione o Tipo de saida do Aparelho");
                erros.Add(false);
            }
            else
            {
                ep.SetError(cbTipoSaida, "");
            }
        }
    }
}
