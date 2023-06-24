package com.padroesestruturais.Adapter;

public class CartaoCredito {

    private int numero;
    private String nome;
    private int validade;
    private int cvv;

    private double limite = 5000;

    public CartaoCredito(int numero, String nome, int validade, int cvv) {
        this.numero = numero;
        this.nome = nome;
        this.validade = validade;
        this.cvv = cvv;
    }

    public int getNumero() {
        return numero;
    }

    public String getNome() {
        return nome;
    }

    public int getCvv() {
        return cvv;
    }

    public int getValidade() {
        return validade;
    }

    public boolean abaixarLimite(double valor) {
        if(valor < this.limite) {
            this.limite = limite - valor;
            return true;
        }
        return false;
    }

    public double getLimite() {
        return limite;
    }
}