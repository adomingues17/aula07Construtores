using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace aula05
{
    
    
        public class Produto
        {
            // Propriedades
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public int QuantidadeEmEstoque { get; private set; }

            // Construtor
            public Produto(int codigo, string nome, decimal preco, int quantidade)
            {
                this.Codigo = codigo;
                this.Nome = nome;
                this.Preco = preco;
                this.QuantidadeEmEstoque = quantidade;
            }

            // Exibir informações do produto
            public void ExibirInformacoes()
            {
                Console.WriteLine($"Produto: {this.Nome} | Código: {this.Codigo} | Preço: R${this.Preco} | Estoque: {this.QuantidadeEmEstoque}");
            }




            // Verificar se o estoque é suficiente para uma venda
            public bool VerificarEstoque(int quantidade)
            {
                if (quantidade <= 0)
                {
                    Console.WriteLine("Quantidade inválida.");
                    return false;
                }

                if (quantidade <= this.QuantidadeEmEstoque)
                {
                    Console.WriteLine("Estoque suficiente para a venda.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Estoque insuficiente para a quantidade solicitada.");
                    return false;
                }
            }


            // Vender produto
            public void Vender(int quantidade)
            {
                if (quantidade <= 0)
                {
                    Console.WriteLine("Quantidade inválida para venda.");
                    return;
                }

                if (quantidade > this.QuantidadeEmEstoque)
                {
                    Console.WriteLine("Estoque insuficiente para realizar a venda.");
                    return;
                }

                this.QuantidadeEmEstoque -= quantidade;
                Console.WriteLine($"Venda de {quantidade} unidade(s) realizada com sucesso.");
            }

            // Repor estoque
            public void ReporEstoque(int quantidade)
            {
                if (quantidade <= 0)
                {
                    Console.WriteLine("Quantidade inválida para reposição.");
                    return;
                }

                this.QuantidadeEmEstoque += quantidade;
                Console.WriteLine($"Estoque aumentado em {quantidade} unidade(s).");
            }

            public Produto ClonarComQuantidade(int quantidade)
            {
                return new Produto(this.Codigo, this.Nome, this.Preco, quantidade);
            }

        }


        /*
        //propriedades
        //digitar prop + tab para auxliar no preenchimento
        public int Codigo { get; set; }

        public string? Nome { get; set; }
        //? utilizar para sinalizar que a variável Nome é não nula, isso pode dar problema quando for utilizar banco de dados
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        //propfull + tab + tab

        //Construtor
        //ctor + tab para criar o construtor
         
             public Produto(int codigo, string nome, decimal preco, int quantidade)
             {
                 this.Codigo = codigo;
                 this.Nome = nome;
                 this.Preco = preco;
                 this.QuantidadeEmEstoque = quantidade;
             }    


        public void ExibirInformacoes()
        {
            Console.WriteLine($"" +
                $"Código: {Codigo}\n " +
                $"Produto: {Nome}\n" +
                $"Preço: {Preco}\n" +
                $"Quantidade: {QuantidadeEmEstoque}\n" +
                $"----------------------------------------"
                );
        }

      public bool VerificarEstoque(int quantidade)
        {
            if (quantidade <= 0)
            {
                Console.WriteLine("Quantidade inválida");
                return false;
            }

            if (quantidade <= QuantidadeEmEstoque)
            {
                Console.WriteLine("Estoque suficiente para a venda.");
                return true;
            }
            else
            {
                Console.WriteLine("Estoque Insuficiente");
                return false;
            }
        }

        //Metodo Vender Produto
        public void Vender(int quantidade)
        {
            if (VerificarEstoque(quantidade))
            {
                QuantidadeEmEstoque -= quantidade;
                Console.WriteLine($"Novo Estoque de {Nome} é de {QuantidadeEmEstoque}  ");
            }
            else
            {
                Console.WriteLine($"Venda não realizada estoque inalterado: {QuantidadeEmEstoque}");
            }
        }

        public Produto ClonarQuantidade(int quantidade)
        {
            return new Produto(this.Codigo, this.Nome, this.Preco, quantidade);
        }
        ]*/
    }

