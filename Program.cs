using System;

namespace JogoDaVida
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto Pessoa
            Pessoa pessoa = new Pessoa("", 0);

            // Input para o nome
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            // Input para a idade
            Console.Write("Digite a idade da pessoa: ");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            {
                Console.WriteLine("Idade inválida. Por favor, digite novamente.");
                Console.Write("Digite a idade da pessoa: ");
            }

            // Configurar o nome e a idade da pessoa usando os métodos SetNome e SetIdade
            pessoa.SetNome(nome);
            pessoa.SetIdade(idade);

            // Imprimir os dados da pessoa
            Console.WriteLine("Dados da pessoa:");
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Idade: " + pessoa.Idade);
        }
    }
}
