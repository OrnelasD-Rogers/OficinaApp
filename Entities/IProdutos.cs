namespace Entities
{
    public interface IProdutos
    {
        int Estoque { get; set; }
        int IdProduto { get; set; }
        string Produto { get; set; }
        double ValorVenda { get; set; }
        int Quantidade { get; set; }
        double SubTotal { get; set; }

        void CalculcaSubTotal();
    }
}