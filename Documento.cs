using System;

public class Documento
{
    public string Nome { get; set; } = "";
    public string Numero { get; set; } = "";
    public DateTime DataEmissao { get; set; } = DateTime.Now;

    public virtual void Preencher()
    {
        Console.WriteLine("Preenchendo dados genéricos do documento...");
        Console.Write("Digite o nome: ");
        Nome = Console.ReadLine();

        Console.Write("Digite o número do documento: ");
        Numero = Console.ReadLine();

        Console.Write("Digite a data de emissão (dd/mm/aaaa): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataEmissao))
        {
            DataEmissao = dataEmissao;
        }
        else
        {
            Console.WriteLine("Data inválida. Usando data atual.");
            DataEmissao = DateTime.Now;
        }
    }
}
