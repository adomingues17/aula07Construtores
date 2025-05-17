using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*teste*/
/*teste2*/
namespace aula05
{
    public class Carrinho
    {
        //declarar lista armazena objetos do tipo produto
        //representar os itens do carrinho
        //List<Produto> é uma estrutura de dados que armazena coleções
        private List<Produto> itens = new List<Produto>();

        //Define o método para adicionar produtos
        //produto(Letra minúscula) é o objeto da classe Produto
        //quantidade indica quantos produtos devem ser adicionados
        public void AdicionarProduto(Produto produto, int quantidade)
        {
            if (!produto.VerificarEstoque(quantidade))
            {
                Console.WriteLine("Não tem estoque  " +
                    "para adicionar ao carrinho");
                return;
            }
            Produto itemCarrinho = produto.ClonarComQuantidade(quantidade);

            //método que insere dentro da List<Produo> itens
            itens.Add(itemCarrinho);
            Console.WriteLine($"" +
                $"{quantidade} x {produto.Nome} adicionado ao carrinho");
        }

        public void ExibirCarrinho()
        {
            if (itens.Count == 0)
            {
                Console.WriteLine("Carrinho vazio");
                return;
            }

            Console.WriteLine("\n--- Carrinho de Compra ---");
            decimal total = 0;

            //percorrer a lista itens
            foreach (var item in itens)
            {
                Console.WriteLine($"" +
                    $"{item.Nome} - {item.QuantidadeEmEstoque} x R$ {item.Preco}" +
                    $" = R$ {item.Preco * item.QuantidadeEmEstoque}");

                total += item.Preco * item.QuantidadeEmEstoque;
            }
            Console.WriteLine($"Total da compra: R$ {total}");
        }

        public void FinalizarCompra(List<Produto> produtos)
        {
            foreach (var item in itens)
            {
                var produtoOriginal = produtos.Find(p => p.Codigo == item.Codigo);
                if (produtoOriginal != null)
                {
                    produtoOriginal.Vender(item.QuantidadeEmEstoque);
                }
            }
            itens.Clear();
            Console.WriteLine("Compra Finalizada e estoque atualizado");

        }



        /*
        public void ExibirCarrinho() {
            if(itens.Count == 0) {
                Console.WriteLine("Carrinho vazio.");
                return;
            }
            Console.WriteLine("\n--- Carrinho de compras ---");
            decimal total = 0;

            //percorrer a lista itens
            foreach (var item in itens) {
                Console.WriteLine($"{item.Nome} - {item.QuantidadeEmEstoque}");
            }
        }
       */



    }
}
