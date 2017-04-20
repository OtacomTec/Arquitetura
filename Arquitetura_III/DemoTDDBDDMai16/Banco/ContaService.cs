namespace Banco
{
    public class ContaService
    {
        private readonly IContaRepository _contaRepository;

        public ContaService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        public Conta ObterContaPorNumero(string numero)
        {
            return _contaRepository.ObterContaPorNumero(numero);
        }
    }
}