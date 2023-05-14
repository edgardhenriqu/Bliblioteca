namespace Projeto_Integrador;
class Program
{
    static void Main(string[] args)
    {
        
        Produto[] livros = new Produto[50];

        int posicao = 0;
        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("\n\nEscolha a opção que deseja:");
            Console.WriteLine("1. Novo");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Remover Produto");
            Console.WriteLine("4. Entrada de Produto");
            Console.WriteLine("5. Saída de Estoque");
            Console.WriteLine("0. Sair");
            opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você escolhe a opcao " + opcao);

            if (opcao == 1)
            {
                Produto livro = new Produto();

                Console.WriteLine("\n\nInforme o Nome do Livro:");
                livro.Nome = Console.ReadLine();

                Console.WriteLine("\n\nInforme o Preço:");
                livro.Preco = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("\n\nInforme o Autor:");
                livro.Autor = Console.ReadLine();

                Console.WriteLine("\n\nInforme o Genero:");
                livro.Genero = Console.ReadLine();

                Console.WriteLine("\n\nInforme a Quantidade");
                livro.Quantidade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n>>Livro registrado!!!");

                livros[posicao] = livro;
                posicao++;
            }
            else if (opcao == 2)
            {
                for (int cont = 1; cont < posicao; cont++)
                {
                    Console.WriteLine($"{cont}. {livros[cont].Nome} ({livros[cont].Preco})" +", Quantidade: " + livros[cont].Quantidade);
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("\n\nInforme o Nome do Livro");
                string Nome = Console.ReadLine();

                int posicaoRemover = -1;

                for (int pos = 0; pos < posicao; pos++)
                {
                    if (livros[pos].Nome == Nome)
                    {
                        posicaoRemover = pos;
                        break;
                    }
                }

                if (posicaoRemover == (posicao-1))
                {
                    livros[posicao - 1] = null;
                    posicao--;
                }
                else
                {
                    for (int pos = posicaoRemover + 1; pos < posicao; pos++)
                    {
                        livros[pos - 1] = livros[pos];
                    }
                    livros[posicao - 1] = null;
                    posicao--;
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine ("\nInforme o Nome do Livro");
                string Nome = Console.ReadLine();

                Console.WriteLine ("\nInforme a quantidade que deseja acrecentar no estoque");
                int Quantidade = int.Parse (Console.ReadLine());

                bool livroEncontrado = false;

                for (int i = 0; i < posicao; i++)
                {
                    if (livros[i].Nome == Nome)
                    {
                        livros[i].Quantidade += Quantidade;
                        livroEncontrado = true;
                        Console.WriteLine($"\n>> Foi adicionada a quantidade de {Quantidade} ao livro {Nome}");
                        
                    }
                }
                if (!livroEncontrado)
                {
                    Console.WriteLine("\n>> Livro não encontrado.");
                }
            }
            else if (opcao == 5)
            {
                Console.WriteLine ("\nInforme o Nome do Livro");
                string Nome = Console.ReadLine();

                Console.WriteLine ("\nInforme a quantidade que deseja retirar do estoque");
                int Quantidade = int.Parse (Console.ReadLine());

                bool livroEncontrado = false;

                for (int i = 0; i < posicao; i++)
                {
                    if (livros[i].Nome == Nome)
                    {
                        livros[i].Quantidade -= Quantidade;
                        livroEncontrado = true;
                        Console.WriteLine($"\n>> Foi remolvido a quantidade de {Quantidade} ao livro {Nome}");
                        
                    }
                }
                if (!livroEncontrado)
                {
                    Console.WriteLine("\n>> Livro não encontrado.");
                }
            }
        }
    }
}