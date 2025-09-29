using Xunit;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void ExecutarOperacao_Soma_DeveCalcularCorretamente()
        {
            var calculadora = new Calculadora();
            var soma = new Soma(10, 5);
            
            calculadora.ExecutarOperacao(soma);
            
            Assert.Equal(15, soma.Resultado);
        }

        [Fact]
        public void ExecutarOperacao_Subtracao_DeveCalcularCorretamente()
        {
            var calculadora = new Calculadora();
            var subtracao = new Subtracao(10, 3);
            
            calculadora.ExecutarOperacao(subtracao);
            
            Assert.Equal(7, subtracao.Resultado);
        }

        [Fact]
        public void ExecutarOperacao_Multiplicacao_DeveCalcularCorretamente()
        {
            var calculadora = new Calculadora();
            var multiplicacao = new Multiplicacao(4, 5);
            
            calculadora.ExecutarOperacao(multiplicacao);
            
            Assert.Equal(20, multiplicacao.Resultado);
        }

        [Fact]
        public void ExecutarOperacao_Divisao_DeveCalcularCorretamente()
        {
            var calculadora = new Calculadora();
            var divisao = new Divisao(15, 3);
            
            calculadora.ExecutarOperacao(divisao);
            
            Assert.Equal(5, divisao.Resultado);
        }

        [Fact]
        public void ExecutarOperacao_DivisaoPorZero_DevePropagaException()
        {
            var calculadora = new Calculadora();
            var divisao = new Divisao(10, 0);
            
            Assert.Throws<DivideByZeroException>(() => calculadora.ExecutarOperacao(divisao));
        }
    }
}