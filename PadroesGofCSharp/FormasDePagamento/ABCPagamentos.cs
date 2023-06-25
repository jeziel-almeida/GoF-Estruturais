namespace PadroesGofCSharp.FormasDePagamento;

public class ABCPagamentos
{
    public void pagarEmCartaoCredito(int numero, string nome, int validade, int cvv, decimal valor)
    {
        if(validade > 2023) 
        {
            Console.WriteLine("ABCPagamentos: Pagamento de "+valor+" CONFIRMADO para cartão do titular: " + nome);
        } else {
            Console.WriteLine("ABCPagamentos: Pagamento de "+valor+" NÃO CONFIRMADO para cartão do titular: " + nome);
        }
    }
}