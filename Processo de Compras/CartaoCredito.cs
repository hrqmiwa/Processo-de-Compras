using System;

public class CartaoCredito : Pagamento
{
    public string NumeroCartao { get; set; }
    public int Parcelas { get; set; }

    public override void Processar()
    {
        Console.WriteLine($"Pagamento de R$ {Valor} realizado no cartão {NumeroCartao} em {Parcelas}x.");
    }
}