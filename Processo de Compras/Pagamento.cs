using System;

public abstract class Pagamento
{
    public double Valor { get; set; }
    public DateTime Data { get; set; }

    public virtual void Processar()
    {
        Console.WriteLine("Iniciando pagamento...");
    }
}