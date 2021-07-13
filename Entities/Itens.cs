using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Itens : IProdutos
    {
        public int IdProduto { get; set; }
        public string Produto { get; set; }
        public double ValorVenda { get; set; }
        public int Estoque { get; set; }
        public int Quantidade { get; set; }
        public double SubTotal { get; set; }

        public void CalculcaSubTotal()
        {
            SubTotal = ValorVenda * Quantidade;
        }

        
    }
}
