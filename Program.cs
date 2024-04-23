using System;

namespace JogoDaVida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas vindas ao Jogo da vida!\nAqui, você terá um longo caminho em sua jornada.\nVocê escolherá a vida que quiser, pode escolher seu nome, idade, carros, casas, alguém para estar do seu lado, vai poder decidir se quer filhos e todas as outras coisas, a vida ideal.\nSaiba que em cada momento de sua trajetória você terá que cumprir com algumas responsabilidades, mas não se preocupe, pois aqui a vida é sua, e você decidirá o melhor caminho a seguir.");
            Console.WriteLine("Vamos começar?");
            Pausa();

            // Instanciar um objeto Pessoa
            Pessoa pessoa = new Pessoa("", 0);

            // Input para o nome
            Console.WriteLine("Então vamos lá!\nVocê acabou de nascer, teve um nascimento lindo, todos te amam, e não viam a hora de você nascer.\nBoas vindas à sua vida!");
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            // Configurar o nome da pessoa
            pessoa.SetNome(nome);

            // Imprimir mensagem de boas-vindas com o nome da pessoa
            Console.WriteLine($"Muito bem {pessoa.Nome}, nos primeiros meses você deixou seus pais loucos,\nvocê costumava ficar quase todas as noites sem dormir, tem um lindo quarto, todos te amam, é uma briga para não devolver você para os seus pais,\nvocê tem ótimos tios e tias.");
            Console.WriteLine("Passaram alguns anos...");
            
            Console.WriteLine("Chegou a hora de ir para escola.");
            Pausa();


            // Instanciar um objeto Escola
            Escola escola = new Escola("", "");

            // Input para o nome da escola
            Console.WriteLine("Escolha o nome da sua escola:");
            string nomeEscola = Console.ReadLine();
            escola.SetNomeEscola(nomeEscola);

            // Input para o nome da professora
            Console.WriteLine("Qual o nome da sua professora?");
            string nomeProfessora = Console.ReadLine();
            escola.SetNomeProfessora(nomeProfessora);

            // Para imprimir os dados da escola
            Console.WriteLine($"Escola: {escola.NomeEscola}");
            Console.WriteLine($"Professora: {escola.NomeProfessora}");
        }

        // Método para pausar e aguardar entrada do usuário
        static void Pausa()
        {
            Console.WriteLine("Digite qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
