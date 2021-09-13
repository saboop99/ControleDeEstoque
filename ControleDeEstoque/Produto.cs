using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ControleDeEstoque
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
{
    public class Produto
    {
        //declaração dos dados do produto
        public string Nome;
        public double Preço;
        public int Quantidade;

        // definição do método construtor, para ter uma memória reserva
        public Produto (string nome, double preço, int quantidade)
        {
            Nome = nome;
            Preço = preço;
            Quantidade = quantidade;
                
        }

        //operação matemática para definir o valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return Preço * Quantidade;
        }

        //operação para definir a adição de produtos ao estoque
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        // operação para definir a subtração de produtos ao estoque
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        //fazer o override para mostrar os dados na tela com as modificações dos valores digitados pelo usuário, dando a ele os dados atualizados
        public override string ToString()
        {
            return Nome 
                + ", R$" 
                + Preço.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade 
                + "unidades, Total: R$ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    
}
