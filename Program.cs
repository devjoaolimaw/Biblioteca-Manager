using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo à Biblioteca!");

        // Lista para armazenar os livros disponíveis na biblioteca
        List<string> livrosDisponiveis = new List<string>();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Adicionar novo livro");
            Console.WriteLine("2. Emprestar livro");
            Console.WriteLine("3. Devolver livro");
            Console.WriteLine("4. Listar livros disponíveis");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            // Captura e valida a opção do usuário
            string input = Console.ReadLine();
            int opcao;
            if (!int.TryParse(input, out opcao) || opcao < 1 || opcao > 5)
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    // Adicionar novo livro
                    Console.Write("Digite o nome do livro a ser adicionado: ");
                    string novoLivro = Console.ReadLine();
                    livrosDisponiveis.Add(novoLivro);
                    Console.WriteLine($"Livro '{novoLivro}' adicionado com sucesso.");
                    break;
                case 2:
                    // Emprestar livro
                    if (livrosDisponiveis.Count == 0)
                    {
                        Console.WriteLine("Não há livros disponíveis para empréstimo.");
                    }
                    else
                    {
                        Console.WriteLine("Livros disponíveis para empréstimo:");
                        for (int i = 0; i < livrosDisponiveis.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {livrosDisponiveis[i]}");
                        }

                        Console.Write("Digite o número do livro que deseja emprestar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceEmprestar) && indiceEmprestar >= 1 && indiceEmprestar <= livrosDisponiveis.Count)
                        {
                            string livroEmprestado = livrosDisponiveis[indiceEmprestar - 1];
                            livrosDisponiveis.RemoveAt(indiceEmprestar - 1);
                            Console.WriteLine($"Você emprestou o livro '{livroEmprestado}'.");
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido. Operação de empréstimo cancelada.");
                        }
                    }
                    break;
                case 3:
                    // Devolver livro
                    Console.Write("Digite o nome do livro a ser devolvido: ");
                    string livroDevolvido = Console.ReadLine();
                    livrosDisponiveis.Add(livroDevolvido);
                    Console.WriteLine($"Você devolveu o livro '{livroDevolvido}'.");
                    break;
                case 4:
                    // Listar livros disponíveis
                    if (livrosDisponiveis.Count == 0)
                    {
                        Console.WriteLine("Não há livros disponíveis.");
                    }
                    else
                    {
                        Console.WriteLine("Livros disponíveis na biblioteca:");
                        foreach (var livro in livrosDisponiveis)
                        {
                            Console.WriteLine($"- {livro}");
                        }
                    }
                    break;
                case 5:
                    // Sair do programa
                    Console.WriteLine("Obrigado por utilizar a Biblioteca. Até mais!");
                    return;
            }
        }
    }
}
