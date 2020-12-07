using Calculadora.Interface;

namespace Calculadora.Lib
{
    public class Operacoes : ICalc
    {
        public float addition(float[] num1)
        {
            float result = num1[0];
            for(int i=1; i<num1.Length; i++) 
            {
                result += num1[i];
            }
            return result;
        }

        public float subtration(float[] num1)
        {
            float result = num1[0];
            for(int i=1; i<num1.Length; i++) 
            {
                result -= num1[i];
            }
            return result;
        }

        public float multiplication(float[] num1)
        {
            float result = num1[0];
            for(int i=1; i<num1.Length; i++) 
            {
                result *= num1[i];
            }
            return result;
        }

        public float division(float[] num1)
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