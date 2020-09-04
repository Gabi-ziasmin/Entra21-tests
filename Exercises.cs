using System;
using System.Collections.Generic;
using Xunit;

namespace Entra21_tests
{
    public class Exercises
    {
        // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício1B,
        // então a aplicação deverá restornar todos os números de 1 a 10 de forma decrescente.

        [Fact]
        public int[] Exercise1A()
        {
            var numbers = new int[10];

            for (int i = 1; i < 11; i++)
            {
                numbers[i - 1] =  i;   
            }

            return numbers;
        } 
        
        [Fact]
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


        // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício1C,
        // então a aplicação deverá restornar todos os números de 1 a 10, mas somente os pares.
        [Fact]
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

        [Fact]
        public int Exercise2()
        {
            var sum = 0;

            for (int counter = 1; counter < 101; counter++)
            {
                sum += counter;
            }
        
            return sum;
        }

        // [Fact]
        // public int[] Exercise3()
        // {
        //     var numbers = new int[100];
        //     var counter = 0;

        //     for (int i = 0; i < 200; i+=2)
        //     {
        //         var index = counter - 1;
        //         numbers[i] = counter; 
        //     }

        //     return numbers;
        // }

    
        public double Exercise4(List<int> ages)
        {
            var sum = 0.0;

            var respostas = ages.Count;

            foreach (var item in ages)
            {
                sum += item;
            }

            var avarage = (sum / respostas);

            return avarage;
        }

         [Fact]
        public double Exercise5()
        {
            var idade = 0;
            var womenAge = new Double[5]{15,30,35,16,20};

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


        // [Fact]
        // public double Exercise6()
        // {
        //     var ears = 3;
        //     var dayCig = 10;
        //     var price = 7.0;

        //     var totalEars = ears * 365;
        //     var totalCig = dayCig * totalEars;
        //     var totalPrice = price / 20;

        //     var totalGasto = totalCig * totalPrice; 

        //    return totalGasto;           
        // }
    }
}
