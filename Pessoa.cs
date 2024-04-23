public class Pessoa
{
    public string Nome { get; private set; } = "";
    public int Idade { get; private set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void SetNome(string nome)
    {
        Nome = nome;
    }
}
