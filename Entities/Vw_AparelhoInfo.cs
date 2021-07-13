using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vw_AparelhoInfo
    {
        public int IdAparelho { get; set; }
        public int IdCliente { get; set; }
        public int IdTecnico { get; set; }
        public string Nome { get; set; }
        public string NomeTecnico { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public string Problema { get; set; }
        public string Observacao { get; set; }
        public string Orcamento { get; set; }
        public double MaoDeObra { get; set; }
        public bool Urgencia { get; set; }
        public bool Revisao { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Estado Estado { get; set; }
        public string Cor { get; set; }

    }
}
