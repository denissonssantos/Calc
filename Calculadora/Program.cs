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
            Console.WriteLine("Soma: " + op.addition(values));
            Console.WriteLine("Subtração: " + op.subtration(values));
            Console.WriteLine("Multiplicação: " + op.multiplication(values));
            Console.WriteLine("Divisão: " + op.division(values));
        }
    }
}
