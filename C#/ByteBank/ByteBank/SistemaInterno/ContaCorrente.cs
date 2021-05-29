namespace ByteBank.SistemaInterno
{
    public class ContaCorrente : Conta
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="titular">Titular da <see cref="ContaCorrente"/>.</param>
        /// <param name="saldo">Saldo inicial da <see cref="ContaCorrente"/>.</param>
        public ContaCorrente(string titular, double saldo) : base(titular, saldo)
        {
            TipoConta = "Conta Corrente";
            Tarifa = 0.25;
            Saldo = saldo - (saldo * Tarifa);
        }
    }
}