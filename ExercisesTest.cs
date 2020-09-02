using System;
using Xunit;

namespace Entra21_tests
{
    public class ExercisesTest
    {
        // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício1B,
        // então a aplicação deverá restornar todos os números de 1 a 10 de forma decrescente.

        [Fact]
        public void shoul_return_an_array_from_10_to_1()
        {
            // Dado / Steup
            var exercises = new Exercises();

            // Quando / Ação 
            int[] returnedValues = exercises.Exercise1B();

            // Deve / Asserções
            Assert.Equal(10, returnedValues[0]);
            Assert.Equal(1, returnedValues[9]);
        }

        // Os números de 1 a 10 de forme crescente, mas apenas aqueles que forem par
        [Fact]
        public void shoul_return_an_array_from_1_to_10_but_only_even()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício1C,
            // então a aplicação deverá restornar todos os números de 1 a 10, mas somente os pares.


            // Dado / Steup
            var exercises = new Exercises();

            // Quando / Ação 
            int[] returnedValues = exercises.Exercise1C();

            // Deve / Asserções
            var expectedOutput = new int [5]{2,4,6,8,10};            
        }

        [Fact]
        public void return_the_sum_of_integers_from_1_to_100()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício2,
            // então a aplicação deverá restornar a soma dos números inteiros de 1 a 100.


            // Dado / Steup
            var exercises = new Exercises();

            // Quando / Ação 
            int returnedValues = exercises.Exercise2();

            // Deve / Asserções
            Assert.Equal(5050, returnedValues);         
        }

        [Fact]
        public void return_all_odd_numbers_less_than_200()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício3,
            // então a aplicação deverá restornar todos os números impares menores que 200.


            // Dado / Steup
            var exercises = new Exercises();

            // Quando / Ação 
            int[] returnedValues = exercises.Exercise3();

            // Deve / Asserções
            var expectedOutput = new int[100]{1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35,37,39,41,43,45,47,49,51,53,55,57,59,61,63,65,67,69,71,73,75,77,79,81,83,85,87,89,91,93,95,97,99,101,103,105,107,109,111,113,115,117,119,121,123,125,127,129,131,133,135,137,139,141,143,145,147,149,151,153,155,157,159,161,163,165,167,169,171,173,175,177,179,181,183,185,187,189,191,193,195,197,199};        
        }
    }
}
