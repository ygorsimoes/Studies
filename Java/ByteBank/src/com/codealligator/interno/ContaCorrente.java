package com.codealligator.interno;

/**
 * Classe responsável pelo gerenciamento das contas correntes criadas.
 */
public class ContaCorrente extends Conta {

    /*
    Construtor.
     */
    public ContaCorrente(String titular, double saldo, double cpf, double numeroAgencia, double numeroConta) {
        super(titular, saldo, cpf, numeroAgencia, numeroConta);

        /*
        Seta a taxa/tarifa da Conta Corrente.
         */
        setTaxa(0.05);
    }
}
