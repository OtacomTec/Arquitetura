namespace Arquitetura.SOLID.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Valida Aniversário da Conta
            // inserir regra  Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}