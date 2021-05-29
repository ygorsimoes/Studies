using System;

namespace ByteBank.Funcionarios
{
    public class Gerente : Funcionario
    {
        /// <summary>
        /// Construtor da classe <see cref="Gerente"/>.
        /// </summary>
        /// <param name="titular">Titular da conta.</param>
        /// <param name="saldo">Saldo da conta.</param>
        public Gerente(string titular, double saldo) : base(titular, saldo)
        {
            Cargo = "Gerente";
            Salario = 4000;
            Bonificacao = 0.30;
        }

        /// <summary>
        /// Altera o salário para o <paramref name="novoSalario"/>.
        /// </summary>
        /// <param name="novoSalario">Valor do novo salário.</param>
        public void NovoSalario(double novoSalario)
        {
            Salario = novoSalario;
            Console.WriteLine($"O salário do titular: {Titular} foi alterado para {Salario}.");
        }
        
        /// <summary>
        /// Altera o titular principal da conta para o <paramref name="novoTitular"/>.
        /// </summary>
        /// <param name="novoTitular">Nome para o novo titular.</param>
        public void AlterarTitular(string novoTitular)
        {
            Titular = novoTitular;
            Console.WriteLine($"O titular foi alterado para {Titular}.");
        }
        
        /// <summary>
        /// Demite um <see cref="Funcionario"/> invativando suas permissões de funcionário.
        /// Caso esteja demitido ele será recontratado.
        /// </summary>
        public void Demissao()
        {
            if (Demitido)
            {
                Demitido = false;
                Console.WriteLine($"O funcionário {Titular} foi recontratado no cargo de {Cargo}.");
            }
            else
            {
                Demitido = true;
                ReceberBonificacao();
                Console.WriteLine($"O funcionário {Titular} foi demitido do cargo de {Cargo}.");
            }
        }
    }
}