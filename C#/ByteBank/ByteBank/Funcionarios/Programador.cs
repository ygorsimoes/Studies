namespace ByteBank.Funcionarios
{
    public class Programador : Funcionario
    {
        /// <summary>
        /// Construtor da classe <see cref="Programador"/>.
        /// </summary>
        /// <param name="titular">Titular da conta.</param>
        /// <param name="saldo">Saldo da conta.</param>
        public Programador(string titular, double saldo) : base(titular, saldo)
        {
            Cargo = "Programador";
            Salario = 8000;
            Bonificacao = 0.35;
        }
    }
}