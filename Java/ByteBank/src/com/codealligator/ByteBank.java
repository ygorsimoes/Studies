package com.codealligator;

import com.codealligator.interno.ContaCorrente;

public class ByteBank {

    public static void main(String[] args) {

        var contaDoMarcio = new ContaCorrente("Márcio Almeida", 100, 1234567890, 1234, 12345);
        var contaDaMariana = new ContaCorrente("Mariana Castro", 3000, 1234567890, 1234, 12345);

        contaDaMariana.Extrato();
        contaDoMarcio.Extrato();
    }
}
