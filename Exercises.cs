using System;
using System.Collections.Generic;
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

    
        public double Exercise4()
        {
            return 0;
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



        // public double Exercise7()
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