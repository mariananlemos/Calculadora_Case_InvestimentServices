namespace Calculadora
{
    public class Multiplicacao : OperacaoBase
    {
        public override char Operador => '*';

        public Multiplicacao(long a, long b) : base(a, b) { }

        public override void Calcular()
        {
            Resultado = (decimal)(OperandoA * OperandoB);
        }
    }
}
