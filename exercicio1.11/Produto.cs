using System.Globalization;

namespace exercicio1._11
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public double Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ","
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque();
        }
    }
}
