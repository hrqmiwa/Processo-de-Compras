using System;

public class Boleto : Pagamento
{
    public string CodigoBarras { get; set; }
    public DateTime DataVencimento { get; set; }

    public override void Processar()
    {
        Console.WriteLine($"Boleto gerado com sucesso. Vencimento para o dia {DataVencimento:dd/MM/yyyy}.");
    }
}