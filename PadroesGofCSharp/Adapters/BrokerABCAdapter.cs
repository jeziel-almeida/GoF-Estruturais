using PadroesGofCSharp.FormasDePagamento;
using PadroesGofCSharp.Models;

namespace PadroesGofCSharp.Adapters;

public class BrokerABCAdapter : BrokerPagamento
{
    public void pagarCartaoCredito(CartaoCredito cartao, decimal valor)
    {
        ABCPagamentos brokerPagamento = new ABCPagamentos();

        brokerPagamento.pagarEmCartaoCredito(cartao.getNumero(), cartao.getNome(), cartao.getValidade(), cartao.getCvv(), valor);
    }
}