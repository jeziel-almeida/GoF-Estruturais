package com.padroesestruturais.Adapter;

/**
 * Broker de Pagamento da XPTO
 */
public class PagXPTO {
    
    public void pagarCartaoVisa(CartaoCredito cartao, double valor) {
        if(cartao.abaixarLimite(valor)) {
            System.out.println("XPTO: Pagamento de "+valor+" CONFIRMADO para cartão Visa do titular: " + cartao.getNome());
        } else {
            System.out.println("XPTO: Pagamento de "+valor+" NÃO CONFIRMADO para cartão Visa do titular: " + cartao.getNome());
        }
    }

    public void pagarCartaoMastercard(CartaoCredito cartao, double valor) {
        if(cartao.abaixarLimite(valor)) {
            System.out.println("XPTO: Pagamento de "+valor+" CONFIRMADO para cartão Mastercard do titular: " + cartao.getNome());
        } else {
            System.out.println("XPTO: Pagamento de "+valor+" NÃO CONFIRMADO para cartão Mastercard do titular: " + cartao.getNome());
        }
    }

}
