using Calculadora.Interface;

namespace Calculadora.Lib
{
    public class Operacoes : ICalc
    {
        public float Addition(float[] num1)
        {
            float result = num1[0];
            for(int i=1; i<num1.Length; i++) 
            {
                result += num1[i];
            }
            return result;
        }

        public float Subtration(float[] num1)
        {
            float result = num1[0];
            for(int i=1; i<num1.Length; i++) 
            {
                result -= num1[i];
            }
            return result;
        }

        public float Multiplication(float[] num1)
        {
            float result = num1[0];
            for(int i=1; i<num1.Length; i++) 
            {
                result *= num1[i];
            }
            return result;
        }

        public float Division(float[] num1)
        {
            float result = num1[0];
            for(int i=1; i<num1.Length; i++) 
            {
                if (num1[i] != 0) {
                    result /= num1[i];
                }
            }
            return result;
        }
    }
}