using PadroesGofCSharp.Models;
using PadroesGofCSharp.FormasDePagamento;

namespace PadroesGofCSharp.Adapters;

public class BrokerXPTOAdapter : BrokerPagamento
{
    public void pagarCartaoCredito(CartaoCredito cartao, decimal valor)
    {
        PagXPTO brokerPagamento = new PagXPTO();

        if(isCartaoVisa(cartao)) 
        {
            brokerPagamento.pagarCartaoVisa(cartao, valor);
        } else 
        {
            brokerPagamento.pagarCartaoMastercard(cartao, valor);
        }
    }

    public Boolean isCartaoVisa(CartaoCredito cartao) {
        // Se o número do cartão for par, ele é visa
        if(cartao.getNumero() % 2 == 0) 
        {
            return true;
        }
        return false;
    }
}