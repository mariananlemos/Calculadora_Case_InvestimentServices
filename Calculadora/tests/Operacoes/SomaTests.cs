using Xunit;

namespace Calculadora.Tests.Operations
{
    public class SomaTests
    {
        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(-5, 3, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(2147483647, 1, 2147483648)]
        [InlineData(-2147483648, -1, -2147483649)]
        public void Calcular_DeveRetornarSomaCorreta(long a, long b, decimal esperado)
        {
            var soma = new Soma(a, b);
            
            soma.Calcular();
            
            Assert.Equal(esperado, soma.Resultado);
        }

        [Fact]
        public void Operador_DeveRetornarMais()
        {
            var soma = new Soma(1, 2);
            
            Assert.Equal('+', soma.Operador);
        }

        [Fact]
        public void ToString_DeveRetornarFormatoCorreto()
        {
            var soma = new Soma(10, 5);
            
            var resultado = soma.ToString();

            Assert.Equal("10 + 5", resultado);
        }

        [Fact]
        public void Propriedades_DevemSerDefinidas()
        {
            var soma = new Soma(15, 25);
            
            Assert.Equal(15, soma.OperandoA);
            Assert.Equal(25, soma.OperandoB);
        }
    }
}