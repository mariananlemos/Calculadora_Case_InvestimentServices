using System;

namespace Calculadora
{
    public class Divisao : OperacaoBase
    {
        public override char Operador => '/';

        public Divisao(long a, long b) : base(a, b) { }

        public override void Calcular()
        {
            if (OperandoB == 0)
                throw new DivideByZeroException("Divisão por zero não permitida.");

            Resultado = Math.Round((decimal)OperandoA / OperandoB, 4);
        }
    }
}
