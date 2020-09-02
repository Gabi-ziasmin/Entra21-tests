using System;
using Xunit;

namespace Entra21_tests
{
    public class Exercises
    {
        // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício1B,
        // então a aplicação deverá restornar todos os números de 1 a 10 de forma decrescente.

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
            var cont = 1;
            var sum = 0;

            while (cont <= 100)
            {
                sum += cont;
                cont++;
            }

            return sum;
        }

        [Fact]
        public int[] Exercise3()
        {
            var numbers = new int[100];
            var counter = 0;

            for (int i = 0; i < 200; i++)
            {
                var index = counter - 1;
                numbers[i] = counter; 
            }

            return numbers;
        }
    }
}
