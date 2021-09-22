using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ControleDeEstoque
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
{
    public class Produto
    {
        /*declaração dos dados do produto
          unico private é o nome, por não estar setado ("regra de negócios")
          Autoproperties usado no Preço e na Quantidade, sendo inputados automaticamente com o get e set, bloquando que o usuário altere os valores
         */
        private string _nome;
        public double Preço { get; private set; }
        public int Quantidade { get; private set; }

        //construtor padrão
        public Produto()
        {

        }
        // definição do método construtor personalizado, para ter uma memória reserva
        public Produto (string nome, double preço, int quantidade)
        {
            _nome = nome;
            Preço = preço;
            Quantidade = quantidade;
                
        }

        // Execução do Properties, sendo "Nome" como se fosse um atributo (desta vez sendo executado apenas no nome)
        public string Nome
        {
            //método GET para obter o nome
            get { return _nome; }
            // método SET para definir o nome
            set
            {
                //condicional If para definir o nome (diferente de nulo e maior que 1)
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome 
                + ", R$" 
                + Preço.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade
                + " unidades, Total: R$ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
