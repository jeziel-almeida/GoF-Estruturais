package com.padroesestruturais.Adapter;

public interface BrokerPagamento {
    
    void pagarCartaoCredito(CartaoCredito cartao, double valor);
}
