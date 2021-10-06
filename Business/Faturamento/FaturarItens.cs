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

        public FaturarItens()
        {

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

        //Pega o produts que é mão de obra caso siga a regra para ser atualizado
        public Produtos UpdateMaoDeObra()
        {
            
            foreach (Produtos item in ItensList)
            {
                //Se o IdItem for != 0 e o IdProduto == 9999 então significa que o produto é uma Mão de Obra Sendo editada
                if (item.IdItem != 0 && item.IdProduto == 9999)
                {
                    return item;
                }
            }

            return null;
        }

        public void RetornaEstoque(int idAparelho)
        {
            List<Produtos> itens = MetodosBd.GetItensByIdAp(idAparelho);
            foreach (Produtos item in itens)
            {

                switch (item.IdProduto)
                {
                    //Caso seja mão de obra(IdItem = 9999) não faz nada
                    case 9999:
                        break;
                    //Caso seja um Adiantamento(IdItem = 8888) não faz nada
                    case 8888:
                        break;
                    //Caso seja um Pagamento(IdItem = 1010) não faz nada
                    case 1010:
                        break;
                        //Adiciona a Quantidade de Itens ao Estoque
                    default:
                        MetodosBd.AddProdutoEstoque(item);
                        break;
                }

            }
        }

    }
}
