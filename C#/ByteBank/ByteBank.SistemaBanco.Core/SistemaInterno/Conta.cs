using System;

namespace ByteBank.SistemaInterno
{
    /// <summary>
    /// Classe abstrata para outras classes de Contas do Sistema Interno.
    /// </summary>
    public abstract class Conta
    {
        // Getters & Setters
        protected string Titular { get; set; }
        protected double Saldo { get; set; }
        protected string TipoConta { get; set; }
        protected double Tarifa { get; set; }
        
        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="titular">Titular da <see cref="Conta"/>.</param>7
        /// <param name="saldo"></param>
        protected Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        /// <summary>
        /// Vizualisa o extrato da <see cref="Conta"/>.
        /// </summary>
        public virtual void Extrato()
        {
            Console.WriteLine($"Titular : {Titular}");
            Console.WriteLine($"Saldo   : {Saldo}");
            Console.WriteLine($"Conta   : {TipoConta}");
            Console.WriteLine($"Tarifa  : {Tarifa}%\n");
        }
        
        /// <summary>
        ///  Realiza um saque da conta.
        /// </summary>
        /// <param name="valor">Valor que irá ser sacado.</param>
        public void Sacar(double valor)
        {
            if (valor < Saldo && valor > Saldo)
            {
                Console.WriteLine($"O saque não foi possível realizar no valor de R${valor}!");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"O saque no valor de R${valor} foi realizado com sucesso!");
            }
        }
        
        /// <summary>
        /// Realiza um deposito para a conta.
        /// </summary>
        /// <param name="valor">Valor que irá ser depositado.</param>
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"O deposito no valor de R${valor} foi realizado com sucesso!");
        }
        
        /// <summary>
        /// Realiza uma transferência de <see cref="Conta"/> para a mesma.
        /// </summary>
        /// <param name="valor">Valor que irá ser transferido para o <paramref name="destino"/>.</param>
        /// <param name="destino">Destino que irá receber o <paramref name="valor"/>.</param>
        public void Transferir(double valor, Conta destino)
        {
            if (valor < Saldo || valor > Saldo)
            {
                Console.WriteLine($"A transferência no valor de R${valor}! não foi possível ser realizada.");
            }
            else
            {
                Console.WriteLine($"O transferência no valor de R${valor} foi realizado com sucesso!");
                Saldo -= valor;
                destino.Saldo += valor;
            }
        }
    }
}