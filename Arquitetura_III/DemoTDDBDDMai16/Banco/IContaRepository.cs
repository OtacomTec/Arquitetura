namespace Banco
{
    public interface IContaRepository
    {
        Conta ObterContaPorNumero(string numero);
    }
}