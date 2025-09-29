using Xunit;

namespace Calculadora.Tests.Operations
{
    public class SubtracaoTests
    {
        [Theory]
        [InlineData(10, 3, 7)]
        [InlineData(5, 8, -3)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -3, -2)]
        [InlineData(2147483647, 1, 2147483646)]
        public void Calcular_DeveRetornarSubtracaoCorreta(long a, long b, decimal esperado)
        {
            // Arrange
            var subtracao = new Subtracao(a, b);
            
            // Act
            subtracao.Calcular();
            
            // Assert
            Assert.Equal(esperado, subtracao.Resultado);
        }

        [Fact]
        public void Operador_DeveRetornarMenos()
        {
            // Arrange
            var subtracao = new Subtracao(1, 2);
            
            // Act & Assert
            Assert.Equal('-', subtracao.Operador);
        }

        [Fact]
        public void ToString_DeveRetornarFormatoCorreto()
        {
            // Arrange
            var subtracao = new Subtracao(20, 8);
            
            // Act
            var resultado = subtracao.ToString();
            
            // Assert
            Assert.Equal("20 - 8", resultado);
        }
    }
}