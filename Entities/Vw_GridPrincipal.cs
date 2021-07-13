using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vw_GridPrincipal
    {
        public int IdAparelho { get; set; }
        public int IdCliente { get; set; }
        public DateTime Entrada { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public char Sexo { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Problema { get; set; }
        public string Cor { get; set; }
        public Estado Estado { get; set; }
        public DateTime Saida { get; set; }
        public bool Urgencia { get; set; }
        public int Revisao { get; set; }
        public DateTime DataModificacao { get; set; }
        
    }
}
