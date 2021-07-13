using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business.Faturamento
{
    public class FaturarPagamento
    {
        public void InsertPagamento(int idAparelho, Pagamentos pagamento)
        {
            Bd bd = new Bd();
            int idPag = bd.InsertPagamentoDbVendasOficina(pagamento);
            InsertPagamentos_Aparelho(idAparelho, idPag);
        }
        public void InsertPagamentoParcelado(int idAparelho, Pagamentos pagamento, int numParcelas)
        {
            DateTime dataParcela = pagamento.DataPag;
            for (int i = 0; i < numParcelas; i++)
            {                
                Pagamentos parcela = new Pagamentos();
                parcela = pagamento;
                parcela.DataPag = dataParcela.AddMonths(i);
                InsertPagamento(idAparelho, parcela);
            }
        }

        private void InsertPagamentos_Aparelho(int idAparelho, int idPagamento)
        {
            Bd bd = new Bd();
            bd.InsertPagamentos_Aparelhos(idAparelho, idPagamento);
        }
    }
}
