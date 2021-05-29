using System;
using ByteBank.SistemaInterno;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario : ContaPoupanca
    {
        // Getters & Setters
        protected string Cargo { get; set; }
        protected double Salario { get; set; }
        protected bool Demitido { get; set; }
        protected double Bonificacao { get; set; }

        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="titular">Titular da <see cref="Conta"/>.</param>
        /// <param name="saldo">Saldo da <see cref="Conta"/>.</param>
        protected Funcionario(string titular, double saldo) : base(titular, saldo)
        {
            Demitido = false;
            TipoConta = "Conta Funcionário (Poupança)";
            Tarifa = 0.02;
            Saldo = saldo - (saldo * Tarifa);
        }

        /// <summary>
        /// Vizualisa o extrato da <see cref="Conta"/>.
        /// </summary>
        public override void Extrato()
        {
            Console.WriteLine($"Titular : {Titular}");
            Console.WriteLine($"Cargo   : {Cargo}");
            Console.WriteLine($"Saldo   : {Saldo}");
            Console.WriteLine($"Salário : {Salario}");
            Console.WriteLine($"Conta   : {TipoConta}");
            Console.WriteLine($"Tarifa  : {Tarifa}%\n");
        }
        
        /// <summary>
        /// Recebe o salário onde é depositado na <see cref="Conta"/>
        /// </summary>
        public void ReceberSalario()
        {
            Saldo += Salario;
            Console.WriteLine($"Salário no valor de R${Salario} recebido com sucesso!");
        }

        /// <summary>
        /// Recebe uma bonificação no salário.
        /// </summary>
        public void ReceberBonificacao()
        {
            double realBonificacao = Salario + (Salario * Bonificacao);
            Salario += Salario + (Salario * Bonificacao);
            Console.WriteLine($"Bonificação de {Bonificacao}% recebido com sucesso! R${realBonificacao}.");
        }
    }
}