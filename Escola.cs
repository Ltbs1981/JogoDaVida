public class Escola
{
    public string NomeEscola { get; private set; } = "";
    public string NomeProfessora { get; private set; } = "";

    public Escola(string nomeEscola, string nomeProfessora)
    {
        NomeEscola = nomeEscola;
        NomeProfessora = nomeProfessora;
    }

    public void SetNomeEscola(string nomeEscola)
    {
        NomeEscola = nomeEscola;
    }

    public void SetNomeProfessora(string nomeProfessora)
    {
        NomeProfessora = nomeProfessora;
    }
}
