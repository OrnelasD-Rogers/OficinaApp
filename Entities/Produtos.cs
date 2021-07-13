using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produtos
    {
        public int IdItem { get; set; }
        public int IdProduto { get; set; }
        public string Produto { get; set; }
        public double ValorVenda { get; set; }
        public int Estoque { get; set; }
        public int Quantidade { get; set; }
        public double SubTotal { get; set; }

        public void CalculcaSubTotal()
        {
            SubTotal = Quantidade * ValorVenda;
        }
    }
}
