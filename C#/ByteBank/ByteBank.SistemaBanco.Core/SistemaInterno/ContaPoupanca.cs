namespace ByteBank.SistemaInterno
{
    public class ContaPoupanca : ContaCorrente
    {
        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="titular">Titular da <see cref="ContaPoupanca"/>.</param>
        /// <param name="saldo">Saldo inicial da <see cref="ContaPoupanca"/>.</param>
        protected ContaPoupanca(string titular, double saldo) : base(titular, saldo)
        {
            TipoConta = "Conta Poupança";
            Tarifa = 0.05;
            Saldo = saldo - (saldo * Tarifa);
        }
    }
}