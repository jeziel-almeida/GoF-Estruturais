using PadroesGofCSharp.Adapters;
using PadroesGofCSharp.Models;

namespace PadroesGofCSharp.Cliente;

/// <summary>
/// Módulo Cliente: O um dos objetivos do padrão adapter é não modificar o módulo cliente a cada
/// nova implementação de pagamento. Dessa forma, novas soluções de pagamento podem ser 
/// acrescentadas ao produto sem haver necessidade do módulo cliente ser alterado.
/// <summary>
public class ServicoPagamento
{
    public void pagarCartaoCredito(BrokerPagamento broker, CartaoCredito cartao, decimal valor)
    {
        broker.pagarCartaoCredito(cartao, valor);
    }
}