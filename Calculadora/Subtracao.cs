namespace Calculadora
{
    public class Subtracao : OperacaoBase
    {
        public override char Operador => '-';

        public Subtracao(long a, long b) : base(a, b) { }

        public override void Calcular()
        {
            Resultado = (decimal)(OperandoA - OperandoB);
        }
    }
}
