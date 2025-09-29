using System;
using System.Collections.Generic;

namespace Calculadora
{
    public static class ConsoleManager
    {
        public static void MostrarOperacoesIniciais(Queue<OperacaoBase> operacoes)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Operações a processar:");
            Console.ResetColor();
            
            int contador = 1;
            foreach (var op in operacoes)
            {
                Console.WriteLine($"   {contador}. {op}");
                contador++;
            }
            Console.WriteLine();
        }

        public static void MostrarResultadoOperacao(OperacaoBase operacao)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"✓ {operacao.OperandoA} {operacao.Operador} {operacao.OperandoB} = {operacao.Resultado}");
            Console.ResetColor();
        }

        public static void MostrarFilaRestante(Queue<OperacaoBase> filaRestante)
        {
            if (filaRestante.Count > 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" Fila restante ({filaRestante.Count} operações):");
                Console.ResetColor();
                
                foreach (var op in filaRestante)
                {
                    Console.WriteLine($"   • {op}");
                }
            }
        }

        public static void MostrarSeparador()
        {
            Console.WriteLine();
            Console.WriteLine("───────────────────────────────────────");
            Console.WriteLine();
        }

        public static void MostrarResultadosFinais(Stack<decimal> pilhaResultados)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Pilha de resultados finais:");
            Console.ResetColor();
            
            foreach (var resultado in pilhaResultados)
            {
                Console.WriteLine($"   → {resultado}");
            }
            
            Console.WriteLine();
            Console.WriteLine("═══════════════════════════════════════");
        }
    }
}