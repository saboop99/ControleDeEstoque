using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ControleDeEstoque
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
{
    public class Produto
    {
        //declaração dos dados do produto, agora em private para o encapsulamento
        private string _nome;
        private double _preço;
        private int _quantidade;

        //construtor padrão
        public Produto()
        {

        }
        // definição do método construtor personalizado, para ter uma memória reserva
        public Produto (string nome, double preço, int quantidade)
        {
            _nome = nome;
            _preço = preço;
            _quantidade = quantidade;
                
        }
        // Execução do Properties, sendo "Nome" como se fosse um atributo
        public string Nome
        {
            //método GET para obter o nome
            get { return _nome; }
            // método SET para definir o nome
            set
            {
                //condicional If para definir o nome (diferente de nulo e maior que 1)
                if(value!=null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        // Execução do Properties, sendo "Preço" como se fosse um atributo
        public double Preço
        {
            //método GET para obter o preço
            get { return _preço; }
        }

        // Execução do Properties, sendo "Quantidade" como se fosse um atributo
        public int Quantidade
        {
            //método GET para obter a quantidade
            get { return _quantidade; }
        }
        //operação matemática para definir o valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return _preço * _quantidade;
        }

        //operação para definir a adição de produtos ao estoque
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }
        
        // operação para definir a subtração de produtos ao estoque
        public void RemoverProduto(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }
        
        //fazer o override para mostrar os dados na tela com as modificações dos valores digitados pelo usuário, dando a ele os dados atualizados
        public override string ToString()
        {
            return _nome 
                + ", R$" 
                + _preço.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + _quantidade 
                + " unidades, Total: R$ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
