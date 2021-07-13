using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
   public class Telefones : Validacao
    {
        public int IdTelefone { get; set; }
        public int Id_Cliente { get; set; }
        public string Numero { get; set; }
        public Tipo Tipo { get; set; }
        public bool Whats { get; set; }

        public bool ValidaTelefone(MaskedTextBox mtbNum, ErrorProvider ep)
        {

            ValidaNumero(mtbNum, ep);
            return ValidaObj();
        }

        private void ValidaNumero(MaskedTextBox mtbNum, ErrorProvider ep)
        {
            if (mtbNum.MaskCompleted == false)
            {
                ep.SetError(mtbNum, "Digite todos os Dígitos do Numero");
                erros.Add(false);
            }
            else
            {
                ep.SetError(mtbNum, "");
            }
        }

        public static bool ValidaNumeroVazio(List<Telefones> telefones, MaskedTextBox mtbNum, ErrorProvider ep)
        {
            erros.Clear();
            if (telefones.Count == 0)
            {
                ep.SetError(mtbNum, "O Cliente deve possuir ao menos um Numero");
                erros.Add(false);
            }
            else
            {
                ep.SetError(mtbNum, "");
            }
            return ValidaObj();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Telefones))
            {
                throw new ArgumentException("O tipo atribuido não é uma classe Telefones");
            }

            Telefones other = obj as Telefones;
            return this.Numero.Equals(other.Numero);
        }

        public override int GetHashCode()
        {
            return this.Numero.GetHashCode();
        }
    }
}
