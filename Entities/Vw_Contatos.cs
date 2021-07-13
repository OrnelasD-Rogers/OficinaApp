using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vw_Contatos
    {
        public int IdContato { get; set; }
        public DateTime DataContato { get; set; }
        public string Tipo { get; set; }
        public string Dialogo { get; set; }
        public string StatusLig { get; set; }
        public string NomeTecnico { get; set; }
        public string Numero { get; set; }
        public Estado Estado { get; set; }
    }
}
