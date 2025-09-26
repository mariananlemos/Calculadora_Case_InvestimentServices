namespace Calculadora
{
    public abstract class OperacaoBase
    {
        public long OperandoA { get; }
        public long OperandoB { get; }
        public decimal Resultado { get; protected set; }
        public abstract char Operador { get; }

        protected OperacaoBase(long a, long b)
        {
            OperandoA = a;
            OperandoB = b;
        }

        public abstract void Calcular();

        public override string ToString()
        {
            return $"{OperandoA} {Operador} {OperandoB}";
        }
    }
}
