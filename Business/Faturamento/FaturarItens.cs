using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business.Faturamento
{
    public class FaturarItens
    {
        List<Produtos> ItensList = new List<Produtos>();

        public FaturarItens(List<Produtos> itensList)
        {
            foreach (Produtos item in itensList)
            {
                item.CalculcaSubTotal();
            }
            ItensList = itensList;
            
        }

        public double ValorTotal()
        { 
            return ItensList.Where(x => x.Produto != "Adiantamento" && x.Produto != "Pagamento").Sum(x => x.SubTotal);
        }

        public double ValorPago()
        {
            return ItensList.Where(x => x.Produto == "Adiantamento" || x.Produto == "Pagamento").Sum(x => x.SubTotal);
        }

        public double ValorAPagar()
        {
            return ValorTotal() - ValorPago();
        }

        public List<Produtos> Itens2Bd()
        {
            List<Produtos> itensBd = new List<Produtos>();
            foreach (Produtos item in ItensList)
            {
                //Se o IdItem for == 0, então significa que o produto não está cadastrado na Tabela itens
                if (item.IdItem == 0)
                {
                    itensBd.Add(item);
                }
            }

            return itensBd;
        }

    }
}
