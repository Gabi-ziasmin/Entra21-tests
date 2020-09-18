using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Entra21_tests
{
    public class Exercises
    {
        public int[] Exercise1A()
        {
            var numbers = new int[10];

            for (int i = 1; i < 11; i++)
            {
                numbers[i - 1] =  i;   
            }

            return numbers;
        } 
        public int[] Exercise1B()
        {
            int[] numbers = new int[10];
            var counter = 0;

            for (int i = 10; i > 0; i--)
            {
                numbers[counter] = i;
                counter++;   
            }

            return numbers;
        }
        public int[] Exercise1C()
        {
            var numbers = new int[5];


            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
                numbers[index] = counter;  
            }

            return numbers;
        }
        public int Exercise2()
        {
            var sum = 0;

            for (int counter = 1; counter < 101; counter++)
            {
                sum += counter;
            }
        
            return sum;
        }

        public int[] Exercise3()
        {
            var numbers = new int[100];
            var counter = 0;

            for (int i = 1; i < 200; i+=2)
            {
                numbers[counter] = i; 
                counter++;
            }

            return numbers;
        }

    
        public double Exercise4(List<int> ages)
        {
            var sum = 0.0;

            var respostas = ages.Count;

            foreach (var item in ages)
            {
                sum += item;
            }

            var media = (sum / respostas);

            return media;

        }

        public double Exercise5(double[] womenAge)
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
        public double Exercise6(int candidato1, int candidato2, int winer)
        {
            if (candidato1 > candidato2)
            {
                winer = 1;
            }
            else if (candidato2 > candidato1)
            {
                winer = 2;
            }
            else
            {
                winer = 3;
            }

            return winer;

        }

        public double Exercise7(int ears, int dayCig, double price)
        {
            var totalEars = ears * 365;
            var totalCig = dayCig * totalEars;
            var totalPrice = price / 20;
            double resposta = 0.0;

            var totalGasto = (totalCig * totalPrice).ToString("0.00"); 
            resposta = double.Parse(totalGasto);

           return resposta;           
        }
        public Boolean Exercise8(double x, double y)
        {
           if (x % y != 0)
           {
               return false;
           }
           else
           {
               return true;
           }
        }
        
        public Boolean Exercise9(int num1, int num2, int num3)
        {
            var result = false;

            if (num1 > num2+num3)
            {
                result = true;
            }

            return result;
        }

        public string Exercise10(double a, double b)
        {
            var maior = ""; 

            if (a > b)
            {
                maior = "a"; 
            }
            else if (b > a)
            {
                maior = "b";
            }
            else
            {
                maior = "igual";
            }

            return maior;
        }
         public double Exercise11(int num1, int num2)
        {
            var soma = num1%num2;

            return soma;
        }
        public int Exercise12(int[] num)
        {
            var pares = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    pares += num[i];
                }
            }

            return pares;
        }
        
        public int Exercise13(int[] num)
        {
            var maior = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > maior)
                {
                    maior = num[i];
                }
            }

            return maior;
        }

        public string Exercise14(List<double> num)
        {
           num.Sort();
           var result = new StringBuilder();
           foreach (var item in num)
           {
               result.Append(item + " < ");
           }
           result.Remove(result.Length-3, 3);

           return result.ToString();
        }

        public (int, int) Exercise15(List<double> num)
        {
            int mult3 = 0;
            int mult5 = 0;
            foreach (var item in num)
            {
                if (item != 0)
                {
                    if (item % 3 == 0)
                    {
                        mult3++;
                        if (item % 5 == 0)
                        {
                            mult5++;
                        }
                    }
                }
            }
            return(mult3, mult5);
        }

        public IEnumerable<int> Exercise17(int number)
        {
            // var results = new List<int>();

            // for (int i = 1; i < 11; i++)
            // {
            //     results.Add(number * i);
            // }
            var multiplicationTable = new List<int>(){1,2,3,4,5,6,7,8,9,10};

            return multiplicationTable.Select(item => item * number);
        
        }

        // public IEnumerable<int> ExerciseTest(int number)
        // {
        //     var sum = new List<int>(){1,2,3,4,5,6,7,8,9,10};

        //     return sum.Select(item => item * number);
        // }
    }          
}   
