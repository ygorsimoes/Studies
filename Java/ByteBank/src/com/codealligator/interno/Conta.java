package com.codealligator.interno;

/**
 * Classe abstrata responsável pelo gerenciamento das contas criadas.
 */
public abstract class Conta {

    /**
     * Nome completo do titular da conta.
     */
    private final String titular;

    /**
     * Saldo total da conta.
     */
    private double saldo;

    /**
     * Taxa aplicada em cada transação.
     */
    private double taxa;

    /**
     * CPF do titular da conta.
     */
    private final double cpf;

    /**
     * Número da agencia.
     */
    private final double numeroAgencia;

    /**
     * Número da conta.
     */
    private final double numeroConta;


    /*
    Construtor.
     */
    public Conta(String titular, double saldo, double cpf, double numeroAgencia, double numeroConta) {
        this.titular = titular;
        this.saldo = saldo;
        this.cpf = cpf;
        this.numeroAgencia = numeroAgencia;
        this.numeroConta = numeroConta;
    }

    /**
     * Exibe o extrato com todas as informações na tela.
     */
    public void Extrato() {
        System.out.printf("""
                ____________________________
                Titular: %s
                Saldo:   %s
                Taxa:    %s
                CPF:     %s
                Agência: %s
                Conta:   %s
                ____________________________
                """, this.titular, this.saldo, this.taxa, this.cpf, this.numeroAgencia, this.numeroConta);
    }

    /**
     * Método responsável pelo deposito de um determinado valor ao saldo total da conta.
     *
     * @param valor para ser depositado.
     */
    public void Depositar(double valor) {

        if (valor <= 1) {
            System.out.println("O deposito só pode ser efetuado com valor acima de 1 real.");
        } else {
            this.saldo += valor;
        }
    }

    /**
     * Método responsável pelo saque de um determinado valor do saldo da conta.
     *
     * @param valor para ser sacado.
     */
    public void Sacar(double valor) {

        if (valor > this.saldo || valor < this.saldo) {
            System.out.println("O saque não pode ser efetuado. Saldo insuficiente.");
        } else if (valor < 1) {
            System.out.println("O saque não pode ser efetuado. O valor é menor do que 1 real.");
        } else {
            this.saldo -= valor;
        }
    }

    /**
     * Método responsável pela transferência de valores de Conta para Conta.
     *
     * @param valor   para ser transferido.
     * @param destino que receberá o valor.
     */
    public void Transferir(double valor, Conta destino) {

        if (valor >= 1) {
            this.saldo -= valor;
            destino.saldo += valor;
        } else {
            System.out.println("A transferência não pode ser efetuada.");
        }
    }
    

    /*
    Getters e Setters.
     */

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public double getTaxa() {
        return taxa;
    }

    public void setTaxa(double taxa) {
        this.taxa = taxa;
        setSaldo(getSaldo() - (getSaldo() * getTaxa()));
    }
}
