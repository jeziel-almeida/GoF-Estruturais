package com.padroesestruturais.Adapter;

public class BrokerXPTOAdapter implements BrokerPagamento {
    
    @Override
    public void pagarCartaoCredito(CartaoCredito cartao, double valor) {
        
        PagXPTO brokerPagamento = new PagXPTO();
  
        if(isCartaoVisa(cartao)) {
            brokerPagamento.pagarCartaoVisa(cartao, valor);
        } else {
            brokerPagamento.pagarCartaoMastercard(cartao, valor);
        }
    }
    
    private boolean isCartaoVisa(CartaoCredito cartao) {
        // Se o número do cartão for par, ele é visa
        if(cartao.getNumero() % 2 == 0) {
            return true;
        }
        return false;
    }
}
