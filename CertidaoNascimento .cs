using System;

public class CertidaoNascimento : Documento
{
    public string NomeHospital { get; set; } = "";
    public string NomePais { get; set; } = "";

    public override void Preencher()
    {
        base.Preencher(); // Chama o método da classe base

        Console.Write("Digite o nome do hospital: ");
        NomeHospital = Console.ReadLine();

        Console.Write("Digite o nome dos pais: ");
        NomePais = Console.ReadLine();
    }
}
