using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Cores : Validacao
    {
        public int IdCor { get; set; }        
        public string Cor { get; set; }


        public bool ValidaCor(List<Cores> cores, ComboBox cbCor, ErrorProvider ep)
        {
            int c = 0;
            foreach (Cores cor in cores)
            {
                //Se uma cor estiver vazia, então é adicionado false na lista
                if (cor.IdCor == 0)
                {
                    c++;
                }
            }
            //Se mais de uma cor estiver vazia
            if (c > 1)
            {
                erros.Add(false);
                ep.SetError(cbCor, "Adicione pelo menos uma Cor ao Aparelho");                
            }
            else
            {
                ep.SetError(cbCor, "");                
            }
            return ValidaObj();
        }
    }
}
