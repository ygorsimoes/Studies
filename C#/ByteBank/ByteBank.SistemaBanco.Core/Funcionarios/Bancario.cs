namespace ByteBank.Funcionarios
{
    public class Bancario : Funcionario
    {   
        /// <summary>
        /// Construtor da classe <see cref="Bancario"/>.
        /// </summary>
        /// <param name="titular">Titular da conta.</param>
        /// <param name="saldo">Saldo da conta.</param>
        public Bancario(string titular, double saldo) : base(titular, saldo)
        {
            Cargo = "Bancário";
            Salario = 3000;
            Bonificacao = 0.15;
        }
    }
}