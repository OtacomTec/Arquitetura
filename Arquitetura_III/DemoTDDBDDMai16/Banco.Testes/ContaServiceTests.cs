using Moq;
using Xunit;

namespace Banco.Testes
{
    public class ContaServiceTests
    {
        [Fact]
        public void ContaService_ObterContaPorNumero_RetornarConta()
        {
            // Arrange
            var repo = new Mock<IContaRepository>();
            var conta = new Conta()
            {
                Numero = "000100"
            };

            repo.Setup(r => r.ObterContaPorNumero("000100")).Returns(conta);
            var contaService = new ContaService(repo.Object);

            // Act
            var contaConsulta = contaService.ObterContaPorNumero("000100");

            // Assert          
            Assert.True(conta.Numero == contaConsulta.Numero);
        }
    }
}