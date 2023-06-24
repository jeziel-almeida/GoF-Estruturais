package com.padroesestruturais.Adapter;

/**
 * Módulo Cliente: O um dos objetivos do padrão adapter é não modificar o módulo cliente a cada
 * nova implementação de pagamento. Dessa forma, novas soluções de pagamento podem ser 
 * acrescentadas ao produto sem haver necessidade do módulo cliente ser alterado.
 */
public class ServicoPagamento {
    
    public void pagarCartaoCredito(BrokerPagamento broker, CartaoCredito cartao, double valor) {
        broker.pagarCartaoCredito(cartao, valor);
    }
  
}