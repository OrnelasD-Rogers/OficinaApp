using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Aparelhos : Validacao
    {
        public int IdAparelho { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Tipo { get; set; }
        public int Id_Marca { get; set; }
        public int Id_Modelo { get; set; }
        public int Id_Estado { get; set; }
        public int Id_Tecnico { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Entrada { get; set; }
        public string Observacao { get; set; }
        public string Problema { get; set; }
        public string Orcamento { get; set; }
        public double MaoDeObra { get; set; }
        public DateTime Saida { get; set; }
        public bool Urgencia { get; set; }
        public bool Revisao { get; set; }
        public DateTime DataModificacao { get; set; }

        public bool ValidaNovoAparelho(ComboBox cbTipo, ComboBox cbMarca, ComboBox cbModelo, TextBox tbObs, TextBox tbProblema, DateTimePicker dtpEntrada, ErrorProvider ep)
        {

            ValidaComboBox(this.Id_Tipo, this.Tipo, "Prrencha o Tipo do Aparelho", cbTipo, ep);
            ValidaComboBox(this.Id_Marca, this.Marca, "Prrencha a Marca do Aparelho", cbMarca, ep);
            ValidaComboBox(this.Id_Modelo, this.Modelo, "Prrencha o Modelo do Aparelho", cbModelo, ep);
            ValidaObs(tbObs, ep);
            ValidaProblema(tbProblema, ep);
            ValidaDataEntrada(dtpEntrada, ep);
            return ValidaObj();
        }

        public bool ValidaIds(ComboBox cbTipo, ComboBox cbMarca, ComboBox cbModelo, ErrorProvider ep)
        {
            ValidaComboBox(this.Id_Tipo, string.Empty, "Prrencha o Tipo do Aparelho", cbTipo, ep);
            ValidaComboBox(this.Id_Marca, string.Empty, "Prrencha a Marca do Aparelho", cbMarca, ep);
            ValidaComboBox(this.Id_Modelo, string.Empty, "Prrencha o Modelo do Aparelho", cbModelo, ep);

            return ValidaObj();
        }

        private void ValidaDataEntrada(DateTimePicker dtpEntrada, ErrorProvider ep)
        {
            DateTime dataLimite = DateTime.Now.AddYears(-1);
            if (this.Entrada < dataLimite)
            {
                ep.SetError(dtpEntrada, $"A data deve ser superior à {dataLimite.ToShortDateString()}");
                erros.Add(false);
            }
            else
                ep.SetError(dtpEntrada, "");
        }

        private void ValidaProblema(TextBox tbProblema, ErrorProvider ep)
        {
            if (this.Problema == string.Empty)
            {
                ep.SetError(tbProblema, "Preencha o Problema do Aparelho");
                erros.Add(false);
            }
            else
                ep.SetError(tbProblema, "");
        }

        private void ValidaObs(TextBox tbObs, ErrorProvider ep)
        {
            if (this.Observacao == string.Empty)
            {
                ep.SetError(tbObs, "Descreva as características do Aparelho. Ex: Bem cuidao; Foi aberto e Etc.");
                erros.Add(false);
            }
            else
                ep.SetError(tbObs, "");
        }

        private void ValidaComboBox(int id, string prop, string message, ComboBox cb, ErrorProvider ep)
        {
            if (id == 0 && prop == string.Empty)
            {
                ep.SetError(cb, message);
                erros.Add(false);
            }
            else
                ep.SetError(cb, "");
        }

        public bool ValidaIdTec(ComboBox cb, ErrorProvider ep)
        {
            if (this.Id_Tecnico == 0)
            {
                ep.SetError(cb, "Defina um Técnico para o Aparelho");
                erros.Add(false);
            }
            else
                ep.SetError(cb, "");

            return ValidaObj();
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Por Favor, Anote os Dados do Aparelho: ");
            sb.AppendLine($"Id do Aparelho: {IdAparelho}");
            sb.AppendLine($"Data de Entrada: {Entrada.ToShortDateString()}");            

            return sb.ToString();
        }

    }
}
