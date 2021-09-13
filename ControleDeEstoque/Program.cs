using System;
using System.Globalization;

namespace ControleDeEstoque
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Pedido ao usuário digitar os dados do produto
            Console.WriteLine("Entre com os dados do produto: ");
            //Pedir ao usuário digitar o dado "nome"
            Console.Write("Nome: ");
            //ler o dado "nome" digitado pelo usuário
            string nome = Console.ReadLine();
            //Pedido ao usuário digitar o dado "preço"
            Console.Write("Preço: ");
            //ler o dado "preço" digitado pelo usuário
            double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Pedir ao usuário digitar o dado "quantidade"
            Console.Write("Quantidade no estoque: ");
            //ler o dado "quantidade" digitado pelo usuário
            int quantidade = int.Parse(Console.ReadLine());

            //Declaração da variável produto, que esta no método construtor na classe produto
            Produto p = new Produto(nome, preço, quantidade);

            // mostrar todos os dado digitados pelo usuário
            Console.WriteLine("Dados do produto: " + p);

            //pedir ao usuário para digitar quantos produtor serão adicionados ao estoque
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            // ler o valor inteiro da quantidade de produtos a ser adicionada digitado pelo usuario
            int qte = int.Parse(Console.ReadLine());
            //chamada da variável AdicionarProduto da classe "Produto"
            p.AdicionarProduto(qte);

            // mostrar na tela a atualização dos dados com a adição do produto no estoque
            Console.WriteLine("Dados do atualizados: " + p);

            // pedir ao usuário para digitar a quantidade a ser removida do estoque
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            //ler o valor inteiro da quantidade de produtos a ser removida digitado pelo usuário
            qte = int.Parse(Console.ReadLine());
            // chamada da variável RemoverProduto da classe "Produto"
            p.RemoverProduto(qte);
            // mostrar na tela os dados atualizados com a quantidade de produtos removida do estoque
            Console.WriteLine("Dados do atualizados: " + p);
        }
    }
}
