using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum Estado : int
    {
        NFV = 1,
        Aprovado = 2,
        Aguardando = 3,        
        NAP = 4,
        Entregue = 5,
        Descarte = 6,
        NAP_Entregue = 7,
        NAP_Descarte = 8
    }
}
