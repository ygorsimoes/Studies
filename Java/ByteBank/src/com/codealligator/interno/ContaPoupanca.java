package com.codealligator.interno;

public class ContaPoupanca extends Conta {

    /*
    Construtor.
     */
    public ContaPoupanca(String titular, double saldo, double cpf, double numeroAgencia, double numeroConta) {
        super(titular, saldo, cpf, numeroAgencia, numeroConta);

        /*
        Seta a taxa/tarifa da Conta Poupança.
         */
        setTaxa(0.1);
    }
}
