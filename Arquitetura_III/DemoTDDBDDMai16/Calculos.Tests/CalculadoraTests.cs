using Xunit;

namespace Calculos.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculo_Adicionar_True()
        {
            Assert.True(Calculadora.Adicao(2,2) == 4);
        }

        [Fact]
        public void Calculo_Subtrair_True()
        {
            Assert.True(Calculadora.Subtracao(6, 2) == 4);
        }

        [Fact]
        public void Calculo_Multiplicar_True()
        {
            Assert.True(Calculadora.Multiplicacao(6, 2) == 12);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(8, 2, 4)]
        [InlineData(6, 3, 2)]
        [InlineData(10, 5, 2)]
        [InlineData(100, 2, 50)]
        public void Calculo_Dividir_True(int v1, int v2, int v3)
        {
            Assert.True(Calculadora.Divisao(v1, v2) == v3);
        }

        // CPF => 11111111111, 2222222222, 3333333333
        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(9)]
        public void Calculo_EhImpar_True(int v1)
        {
            Assert.True(Calculadora.EhImpar(v1));
        }
    }
}