using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Contatos : Validacao
    {
        public int IdContato { get; set; }
        public int IdTecnico { get; set; }
        public int? Id_Telefone { get; set; }
        public int Id_Aparelho { get; set; }
        public int Id_Estado { get; set; }
        public DateTime DataContato { get; set; }
        public string Tipo { get; set; }
        public string Dialogo { get; set; }
        public string StatusLig { get; set; }
        

        public bool ValidaContatoPresencial(ComboBox cbContatante, ComboBox cbStatusAp, ComboBox cbTipoContato,TextBox tbDialogo, ErrorProvider ep)
        {
            //Valida o Tecnico
            ValidaIdComboBox(this.IdTecnico, "Selecione o Contatante", cbContatante, ep);
            //Valida o Estado do Aparelho
            ValidaIdComboBox(this.Id_Estado, "Selecione o Status do Aparelho", cbStatusAp, ep);
            //Valida o Tipo de Contato
            ValidaTextComboBox(this.Tipo, "Selecione o Tipo de Contato", cbTipoContato, ep);
            //Valida se a TextBox de Dialogo Foi preenchida
            ValidaTextBox(this.Dialogo, "Descreva o Dialogo com o Cliente", tbDialogo, ep);

            //Se tudo tiver sido validado, retorna true
            return ValidaObj();
        }

        public bool ValidaContato(ComboBox cbContatante, ComboBox cbStatusAp, ComboBox cbTipoContato, ComboBox cbNumero, ComboBox cbStatusLig, TextBox tbDialogo, ErrorProvider ep)
        {
            erros.Add(ValidaContatoPresencial(cbContatante, cbStatusAp, cbTipoContato, tbDialogo, ep));
            //Valida o Numero do Cliente
            ValidaIdComboBox(this.Id_Telefone, "Selecione o Numero do Cliente", cbNumero, ep);
            //Valida o Status da Ligacao
            ValidaTextComboBox(this.StatusLig, "Selecione o Status do Contato", cbStatusLig, ep);

            return ValidaObj();
        }

        private void ValidaIdComboBox(int? id, string message, ComboBox comboBox, ErrorProvider ep)
        {
            if (id == 0)
            {
                erros.Add(false);
                ep.SetError(comboBox, message);
            }
            else
            {
                ep.SetError(comboBox, "");
            }
        }

        private void ValidaTextBox(string prop, string message, TextBox textBox, ErrorProvider ep)
        {
            if (prop == string.Empty)
            {
                erros.Add(false);
                ep.SetError(textBox, message);
            }
            else
            {
                ep.SetError(textBox, "");
            }
        }

        private void ValidaTextComboBox(string prop, string message, ComboBox comboBox, ErrorProvider ep)
        {
            if (prop == string.Empty)
            {
                erros.Add(false);
                ep.SetError(comboBox, message);
            }
            else
            {
                ep.SetError(comboBox, "");
            }
        }
    }
}
