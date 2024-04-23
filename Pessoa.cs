using System;

namespace JogoDaVida
{
    internal class Pessoa
    {
        // Propriedades auto-implementadas para nome e idade
        public string Nome { get; private set; }
        public int Idade { get; private set; }

        // Construtor para inicializar o objeto com nome e idade
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Métodos para configurar o nome e a idade
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetIdade(int idade)
        {
            Idade = idade;
        }
    }
}
