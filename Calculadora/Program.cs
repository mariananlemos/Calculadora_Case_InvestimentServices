using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<OperacaoBase> filaOperacoes = new Queue<OperacaoBase>();
            filaOperacoes.Enqueue(new Subtracao(14, 8));
            filaOperacoes.Enqueue(new Multiplicacao(5, 6));
            filaOperacoes.Enqueue(new Soma(2147483647, 2));
            filaOperacoes.Enqueue(new Divisao(18, 3));

            Calculadora calculadora = new Calculadora();
            Stack<decimal> pilhaResultados = new Stack<decimal>();

            while (filaOperacoes.Count > 0)
            {
                var operacao = filaOperacoes.Dequeue();
                calculadora.ExecutarOperacao(operacao);

                Console.WriteLine($"{operacao.OperandoA} {operacao.Operador} {operacao.OperandoB} = {operacao.Resultado}");

                pilhaResultados.Push(operacao.Resultado);

                Console.WriteLine("\nFila restante:");
                foreach (var op in filaOperacoes)
                {
                    Console.WriteLine(op);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pilha de resultados finais:");
            foreach (var res in pilhaResultados)
            {
                Console.WriteLine(res);
            }
        }
    }
}
