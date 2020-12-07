using Calculadora.Interface;

namespace Calculadora.Lib
{
    public class Operacoes : ICalc
    {
        public float addition(float[] num1)
        {
            float result = 0;
            for(int i=0; i<num1.Length; i++) 
            {
                result += num1[i];
            }
            return result;
        }

        public float division(float[] num1)
        {
            return 0;
        }

        public float multiplication(float[] num1)
        {
            return 0;
        }

        public float subtration(float[] num1)
        {
            return 0;
        }
    }
}