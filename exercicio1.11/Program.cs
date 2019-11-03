using System;
using System.Globalization;

namespace exercicio1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);

            Console.Write("Digite a quantidade a ser adicionada no estoque: ");
            int qtdeAdicionada = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(qtdeAdicionada);

            Console.WriteLine("Dados Atualizados: " + produto);

            Console.Write("Digite a quantidade a ser removida no estoque: ");
            int qtdeRemovida = int.Parse(Console.ReadLine());
            produto.RemoverProduto(qtdeRemovida);

            Console.WriteLine("Dados Atualizados: " + produto);
        }
    }
}
