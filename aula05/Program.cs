namespace aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Produto produto = new Produto(101, "Mouse Gamer", 150.00m, 10);

            List<Produto> produtos = new List<Produto>() {
                new Produto(1, "Mouse", 15.87m, 10),
                new Produto(2, "Teclado", 10m, 20),
                new Produto(3, "Fone de ouvido", 39.99m, 15),
            };

            Carrinho carrinho = new Carrinho();

            int opcao = 0;

            do
            {
                Console.WriteLine("\n=== MENU DE CONTROLE DE ESTOQUE ===");
                Console.WriteLine("1 - Listar produtos");
                Console.WriteLine("2 - Adicionar produto ao carrinho");
                Console.WriteLine("3 - Exibir carrinho");
                Console.WriteLine("4 - Finalizar compra");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida.");
                    continue;
                }

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Opção invalida");
                        foreach (var p in produtos)
                            p.ExibirInformacoes();
                        break;
                    case 2:
                        //informar o codigo
                        Console.Write("Digite o Código do produto: ");
                        int cod = int.Parse(Console.ReadLine());

                        //busca se o codigo existe em List produtos
                        Produto? produtoSelecionado = produtos.Find(p => p.Codigo == cod);

                        //se não existir sai
                        if (produtoSelecionado == null)
                        {
                            Console.WriteLine("Produto Não Encontrado");
                            break;
                        }

                        //se existie pergunta a quantidade
                        Console.Write("Digite a quantidade para adicionar ao Carrinho: ");
                        int qtd = int.Parse(Console.ReadLine());

                        carrinho.AdicionarProduto(produtoSelecionado, qtd);
                        
                        break;

                    case 3:
                        carrinho.ExibirCarrinho();
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção não encontrada.");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            } while (opcao != 5);
        }



        /*
       // Console.WriteLine("Hello, World!");

        Produto p1 = new Produto(1, "Mouse", 12, 20);
        Produto p2 = new Produto(2, "Teclado", 30, 10);
        Produto p3 = new Produto(3, "Monitor", 180, 6);

        //Carrinho carrinho = new Carrinho();

        p1.ExibirInformacoes();
        p1.VerificarEstoque(30);
        p1.Vender(10);
        p2.ExibirInformacoes();
        p3.ExibirInformacoes();

        int opcao = 0;

        do
        {
            Console.WriteLine("Menu de Opções");
            Console.WriteLine("1 - Exibir informações");
            Console.WriteLine("2 - VerificarEstoque");
            Console.WriteLine("3 - Vender");
            Console.WriteLine("4 - Adicionar ao carrinho");
            Console.WriteLine("5 - Sair Sistema");
            Console.WriteLine("-------------------------");
            Console.Write("Escolha sua opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao >= 6) {
                Console.WriteLine("Opção inválida.");
                continue;                    
            }
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    p1.ExibirInformacoes();
                    break;
                case 2:
                    p1.VerificarEstoque(10);
                    break;
                case 3:
                    p1.Vender(2);
                    break;

                case 5:
                    p1.Vender(2);
                    break;

                default:
                    Console.WriteLine("Sair do Sistema");
                    continue;
            }
        } while (opcao != 5);
        */
    }
}
