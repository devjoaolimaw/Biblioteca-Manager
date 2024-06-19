# Biblioteca-Manager


#### Descrição

O "Biblioteca Manager" é um sistema de gerenciamento de biblioteca desenvolvido em C#, projetado para oferecer funcionalidades básicas de administração de livros, incluindo adição, empréstimo, devolução e listagem de livros disponíveis. Este projeto é ideal para bibliotecas pequenas ou pessoais que desejam automatizar o controle de seu acervo de forma simples e eficiente.

#### Funcionalidades

1. **Adicionar Novo Livro**
   - Permite ao usuário adicionar novos livros ao acervo da biblioteca.
   - Exemplo de código:
     ```csharp
     // Adicionar novo livro
     Console.Write("Digite o nome do livro a ser adicionado: ");
     string novoLivro = Console.ReadLine();
     livrosDisponiveis.Add(novoLivro);
     Console.WriteLine($"Livro '{novoLivro}' adicionado com sucesso.");
     ```

2. **Emprestar Livro**
   - Permite ao usuário emprestar um livro da biblioteca, removendo-o temporariamente do acervo.
   - Exemplo de código:
     ```csharp
     // Emprestar livro
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
     ```

3. **Devolução de Livro**
   - Permite ao usuário devolver um livro emprestado, adicionando-o de volta ao acervo.
   - Exemplo de código:
     ```csharp
     // Devolver livro
     Console.Write("Digite o nome do livro a ser devolvido: ");
     string livroDevolvido = Console.ReadLine();
     livrosDisponiveis.Add(livroDevolvido);
     Console.WriteLine($"Você devolveu o livro '{livroDevolvido}'.");
     ```

4. **Listar Livros Disponíveis**
   - Exibe todos os livros atualmente disponíveis na biblioteca.
   - Exemplo de código:
     ```csharp
     // Listar livros disponíveis
     Console.WriteLine("Livros disponíveis na biblioteca:");
     foreach (var livro in livrosDisponiveis)
     {
         Console.WriteLine($"- {livro}");
     }
     ```

#### Implementação

O projeto utiliza estruturas de controle como loops e estruturas condicionais (`switch-case`) para controlar o fluxo do programa e oferecer opções ao usuário. Além disso, faz uso de uma `List<string>` para armazenar dinamicamente os livros disponíveis na biblioteca, permitindo operações de adição e remoção conforme necessário.

#### Interação com o Usuário

O programa interage com o usuário através da console, fornecendo um menu intuitivo e mensagens informativas para guiar o usuário durante as operações. As entradas do usuário são validadas para garantir que sejam adequadas e seguras.

#### Conclusão

O "Biblioteca Manager 3000" é um projeto robusto e de fácil utilização, desenvolvido em C# sem dependências externas, ideal para gerenciar eficientemente o acervo de livros de uma biblioteca pequena ou pessoal. Com suas funcionalidades básicas de administração de livros, oferece uma solução prática para organizar e controlar os livros disponíveis e emprestados.
