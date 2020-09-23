using System;
using Xunit;

namespace Entra21_tests
{
    class Caculator
    {
        public double Sum(double firstNumber, double secondNumber)
        {
            //Guid myGuid = new Guid(); 
            var result = firstNumber + secondNumber;

            return result;
        }
        public double Divide(double firstNumber, double secondNumber)
        {
            var result = firstNumber / secondNumber;

            return result;
        }
        public double Test(double[] womenAge)
        {
            var idade = 0; 

           for (int i = 0; i < womenAge.Length; i++)
           {
               if (womenAge[i] > 17 && womenAge[i] < 36)
               {
                   idade++;
               }
           }
           var porcent = idade * 100/womenAge.Length; 

           return porcent;           
        }
    }
}
