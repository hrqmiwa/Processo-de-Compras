using System;

public class Pix : Pagamento
{
    public string ChavePix { get; set; }
    public string CodigoCopiaECola { get; set; }

    public override void Processar()
    {
        Console.WriteLine($"Chave Pix {ChavePix} validada. Aguardando recebimento instantâneo.");
    }
}