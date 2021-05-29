using System;
using ByteBank.Funcionarios;
using ByteBank.SistemaInterno;

namespace ByteBank
{
    static class ByteBank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|============ ByteBank ============|\n");
            
            // Lista de Contas
            ContaCorrente[] contas =
            {
                new ContaCorrente("Mara Lúcia", 1000),
                new Bancario("Júlio Cardoso", 100),
                new Gerente("Marta Costa", 100),
                new Programador("Marcio Luna", 0)
            };
            
            // Verifica o extrato de todas as contas.
            foreach (var conta in contas)
            {
                conta.Extrato();
            }
        }
    }
}