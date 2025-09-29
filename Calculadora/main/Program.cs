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

            ConsoleManager.MostrarOperacoesIniciais(filaOperacoes);

            Calculadora calculadora = new Calculadora();
            Stack<decimal> pilhaResultados = new Stack<decimal>();

            while (filaOperacoes.Count > 0)
            {
                var operacao = filaOperacoes.Dequeue();
                calculadora.ExecutarOperacao(operacao);

                ConsoleManager.MostrarResultadoOperacao(operacao);
                pilhaResultados.Push(operacao.Resultado);

                ConsoleManager.MostrarFilaRestante(filaOperacoes);
                ConsoleManager.MostrarSeparador();
            }

            ConsoleManager.MostrarResultadosFinais(pilhaResultados);
        }
    }
}