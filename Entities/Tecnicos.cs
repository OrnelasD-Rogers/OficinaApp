using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Tecnicos
    {
        public int IdTecnico { get; set; }
        public string NomeTecnico { get; set; }
        public string Numero { get; set; }

        public void ValidaTecnico(TextBox tb, ErrorProvider ep)
        {
            if (this.NomeTecnico == string.Empty)
            {
                ep.SetError(tb, "Selecione um Tecnico para o Aparelho");
            }
            else
            {
                ep.SetError(tb, "");
            }
        }
    }
}
