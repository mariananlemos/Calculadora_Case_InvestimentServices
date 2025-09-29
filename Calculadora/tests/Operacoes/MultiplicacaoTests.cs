using Xunit;

namespace Calculadora.Tests.Operations
{
    public class MultiplicacaoTests
    {
        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(-4, 2, -8)]
        [InlineData(0, 100, 0)]
        [InlineData(-3, -4, 12)]
        [InlineData(1000000, 2000, 2000000000)]
        public void Calcular_DeveRetornarMultiplicacaoCorreta(long a, long b, decimal esperado)
        {
            var multiplicacao = new Multiplicacao(a, b);
            
            multiplicacao.Calcular();

            Assert.Equal(esperado, multiplicacao.Resultado);
        }

        [Fact]
        public void Operador_DeveRetornarAsterisco()
        {
            var multiplicacao = new Multiplicacao(1, 2);

            Assert.Equal('*', multiplicacao.Operador);
        }

        [Fact]
        public void ToString_DeveRetornarFormatoCorreto()
        {
            var multiplicacao = new Multiplicacao(7, 9);
            
            var resultado = multiplicacao.ToString();
            
            Assert.Equal("7 * 9", resultado);
        }
    }
}