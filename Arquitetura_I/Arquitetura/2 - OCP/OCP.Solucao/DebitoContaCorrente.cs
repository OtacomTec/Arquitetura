namespace Arquitetura.SOLID.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // inserir regra Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}