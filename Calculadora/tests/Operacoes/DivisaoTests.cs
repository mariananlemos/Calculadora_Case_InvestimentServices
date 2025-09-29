using System;
using Xunit;

namespace Calculadora.Tests.Operations
{
    public class DivisaoTests
    {
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(15, 3, 5)]
        [InlineData(-12, 4, -3)]
        [InlineData(7, 2, 3.5)]
        public void Calcular_DeveRetornarDivisaoCorreta(long a, long b, decimal esperado)
        {
            var divisao = new Divisao(a, b);
            
            divisao.Calcular();
            
            Assert.Equal(esperado, divisao.Resultado);
        }

        [Fact]
        public void Calcular_DivisaoComPrecisao_DeveRetornarResultadoAproximado()
        {
            var divisao = new Divisao(1, 3);
            
            divisao.Calcular();
            
            Assert.Equal(0.3333m, divisao.Resultado);
        }

        [Fact]
        public void Calcular_DivisaoPorZero_DeveLancarException()
        {
            
            var divisao = new Divisao(10, 0);

            var exception = Assert.Throws<DivideByZeroException>(() => divisao.Calcular());
            Assert.Equal("Divisão por zero não permitida.", exception.Message);
        }

        [Fact]
        public void Operador_DeveRetornarBarra()
        {
            
            var divisao = new Divisao(1, 2);
            
            Assert.Equal('/', divisao.Operador);
        }

        [Fact]
        public void ToString_DeveRetornarFormatoCorreto()
        {
            
            var divisao = new Divisao(20, 4);
            
            var resultado = divisao.ToString();
            
            Assert.Equal("20 / 4", resultado);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(-10, -2, 5)]
        public void Calcular_CasosEspeciais_DeveCalcularCorretamente(long a, long b, decimal esperado)
        {
            
            var divisao = new Divisao(a, b);
            
            divisao.Calcular();
            
            Assert.Equal(esperado, divisao.Resultado);
        }
    }
}