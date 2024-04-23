using System;

namespace JogoDaVida
{
    internal class Escola
    {
        public string NomeProfessora { get; private set; }
        public string NomeEscola { get; private set; }

        public Escola(string nomeProfessora, string nomeEscola)
        {
            NomeProfessora = nomeProfessora;
            NomeEscola = nomeEscola;
        }

        // Tornando os métodos SetNomeProfessora e SetNomeEscola públicos
        public void SetNomeProfessora(string nomeProfessora)
        {
            NomeProfessora = nomeProfessora;
        }

        public void SetNomeEscola(string nomeEscola)
        {
            NomeEscola = nomeEscola;
        }
    }
}
