using PadroesGofCSharp.Models;

namespace PadroesGofCSharp.Adapters;

public interface BrokerPagamento
{

    void pagarCartaoCredito(CartaoCredito cartao, decimal valor);
}