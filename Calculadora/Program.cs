using System;
using Calculadora.Lib;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes op = new Operacoes();
            float[] values = {1, 5, 7, 1, 3.4f};
            Console.WriteLine("Soma: " + op.Addition(values));
            Console.WriteLine("Subtração: " + op.Subtration(values));
            Console.WriteLine("Multiplicação: " + op.Multiplication(values));
            Console.WriteLine("Divisão: " + op.Division(values));
        }
    }
}
