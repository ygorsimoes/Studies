using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    static class ByteBank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|============ ByteBank ============|\n");
            
            // Objetos
            var contaJulio = new Gerente("Júlio Cardoso", 100);
            var contaMarta = new Programador("Marta Costa", 100);
            
            // Escopo
            contaJulio.Transferir(200, contaMarta);
            Console.WriteLine();
            
            contaJulio.Extrato();
            contaMarta.Extrato();
        }
    }
}