using System;

class Program
{
    static void Main(string[] args)
    {
        // Cartão
        CartaoCredito cartao = new CartaoCredito()
        {
            Valor = 500,
            Data = DateTime.Now,
            NumeroCartao = "1234-5678-9012-3456",
            Parcelas = 5
        };

        // Pix
        Pix pix = new Pix()
        {
            Valor = 200,
            Data = DateTime.Now,
            ChavePix = "email@teste.com",
            CodigoCopiaECola = "PIX123456"
        };

        // Boleto
        Boleto boleto = new Boleto()
        {
            Valor = 300,
            Data = DateTime.Now,
            CodigoBarras = "123456789000",
            DataVencimento = DateTime.Now.AddDays(7)
        };

        // Processando pagamentos
        cartao.Processar();
        pix.Processar();
        boleto.Processar();
    }
}
