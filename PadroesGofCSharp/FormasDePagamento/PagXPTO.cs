using PadroesGofCSharp.Models;

namespace PadroesGofCSharp.FormasDePagamento;

public class PagXPTO
{
    public void pagarCartaoVisa(CartaoCredito cartao, decimal valor) {
        if(cartao.abaixarLimite(valor)) {
            Console.WriteLine("XPTO: Pagamento de "+valor+" CONFIRMADO para cartão Visa do titular: " + cartao.getNome());
        } else {
            Console.WriteLine("XPTO: Pagamento de "+valor+" NÃO CONFIRMADO para cartão Visa do titular: " + cartao.getNome());
        }
    }

    public void pagarCartaoMastercard(CartaoCredito cartao, decimal valor) {
        if(cartao.abaixarLimite(valor)) {
            Console.WriteLine("XPTO: Pagamento de "+valor+" CONFIRMADO para cartão Mastercard do titular: " + cartao.getNome());
        } else {
            Console.WriteLine("XPTO: Pagamento de "+valor+" NÃO CONFIRMADO para cartão Mastercard do titular: " + cartao.getNome());
        }
    }
}