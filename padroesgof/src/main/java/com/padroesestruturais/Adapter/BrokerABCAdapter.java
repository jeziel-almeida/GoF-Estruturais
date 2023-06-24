package com.padroesestruturais.Adapter;

public class BrokerABCAdapter implements BrokerPagamento {
    
    @Override
    public void pagarCartaoCredito(CartaoCredito cartao, double valor) {

        ABCPagamentos brokerPagamento = new ABCPagamentos();

        brokerPagamento.pagarEmCartaoCredito(cartao.getNumero(), cartao.getNome(), cartao.getCvv(), cartao.getValidade(), valor);
    }
}
