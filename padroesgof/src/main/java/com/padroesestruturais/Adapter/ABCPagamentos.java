package com.padroesestruturais.Adapter;

/**
 * Broker de pagamento para ABCPagamentos
 */
public class ABCPagamentos {
    
    public void pagarEmCartaoCredito(int numero, String nome, int cvv, int validade, double valor) {
        if(validade > 2023) {
            System.out.println("ABCPagamentos: Pagamento de "+valor+" CONFIRMADO para cartão do titular: " + nome);
        } else {
            System.out.println("ABCPagamentos: Pagamento de "+valor+" NÃO CONFIRMADO para cartão do titular: " + nome);
        }
    }
}
