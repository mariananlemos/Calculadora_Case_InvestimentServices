namespace Calculadora
{
    public class Soma : OperacaoBase
    {
        public override char Operador => '+';

        public Soma(long a, long b) : base(a, b) { }

        public override void Calcular()
        {
            Resultado = (decimal)(OperandoA + OperandoB);
        }
    }
}
