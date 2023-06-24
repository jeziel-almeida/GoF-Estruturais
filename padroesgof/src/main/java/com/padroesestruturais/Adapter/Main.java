package com.padroesestruturais.Adapter;

public class Main {

    public static void main(String[] args) {
        
        System.out.println();

        ServicoPagamento servicoPagamento = new ServicoPagamento();

        CartaoCredito cartaoCreditoLuana = new CartaoCredito(100122, "Luana L Almeida", 2030, 193);
        CartaoCredito cartaoCreditoJoao = new CartaoCredito(724987, "João A Morales", 2027, 765);
        
        BrokerPagamento xptoBroker = new BrokerXPTOAdapter();
        servicoPagamento.pagarCartaoCredito(xptoBroker, cartaoCreditoLuana, 2125);
        servicoPagamento.pagarCartaoCredito(xptoBroker, cartaoCreditoLuana, 3000);
        System.out.println("Limite restante: " + cartaoCreditoLuana.getLimite());

        System.out.println();

        servicoPagamento.pagarCartaoCredito(new BrokerABCAdapter(), cartaoCreditoJoao, 15250.90);

        System.out.println();
    }
}