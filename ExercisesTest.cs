using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Entra21_tests
{
    public class ExercisesTest
    {
        private void AssertExercise5(Double[] womenAge, int expectedValue)
        {
            var exercises = new Exercises();

            // Quando / Ação 
            Double returnedValues = exercises.Exercise5(womenAge);

            // Deve / Asserções 
            Assert.Equal(expectedValue, returnedValues); 
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício1B,
        // então a aplicação deverá restornar todos os números de 1 a 10 de forma decrescente.

        [Fact]
        public void shoul_return_an_array_from_1_to_10()
        {
            // Dado / Steup
            var exercises = new Exercises();

            // Quando / Ação 
            var result = exercises.Exercise1A();

            // Deve / Asserções
            var esperado = new int[10]{1,2,3,4,5,6,7,8,9,10};
        } 
        [Fact]
        public void shoul_return_an_array_from_10_to_1()
        {
            // Dado / Steup
            var exercises = new Exercises();

            // Quando / Ação 
            int[] returnedValues = exercises.Exercise1B();

            // Deve / Asserções
            var esperado = new int[10]{10,9,8,7,7,5,4,3,2,1};
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
        public void should_return_5050_the_sum_of_integers_from_1_to_100()
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
        public void should_return_all_odd_numbers_less_than_200()
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

        

        [Fact]
        public void should_return_6_when_passed_4_and_6_and_8()
        {
            // Dado / Steup
           var exercises = new Exercises();
           var myList = new List<int>(){4,6,8};

            // Quando / Ação 
            double returnedValues = exercises.Exercise4(myList);        

            // Deve / Asserções
            Assert.Equal(6, returnedValues);
                     
        }
        
         [Fact]
        public void should_return_60percent_when_passed_5_numbers_contaning_3_between_18_and_35()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício4,
            // então a aplicação deverá restornar a porcentagem das mulheres entre 18 e 35.

            // Dado / Steup
            var womenAge = new Double[5]{15,18,35,20,11};
            AssertExercise5(womenAge, 60);         
        }

        [Fact]
        public void should_return_0percent_when_passed_5_numbers_contaning_none_between_18_and_35()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício4,
            // então a aplicação deverá restornar a porcentagem das mulheres entre 18 e 35.

            // Dado / Steup
            var womenAge = new Double[5]{15,13,11,40,11};
            AssertExercise5(womenAge, 0);        
        }

        [Theory]
        [InlineData(2,3,2)]
        [InlineData(3,2,1)]
        [InlineData(2,2,3)]
        public void should_return_2_when_passed_2_votes_to_candidate1_and_3_votes_to_candidate2(int candidato1,int candidato2, int winer)
        {
            // Dado / Steup
            var exercises = new Exercises();

            // Quando / Ação 
            var returnedValues = exercises.Exercise6(candidato1, candidato2, winer);

            // Deve / Asserções

            Assert.Equal(winer, returnedValues);         
        }
        [Fact]
        public void should_return_2555_when_passed_3_numbers_ears_2_days_10_and_price_7()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o Exercício4,
            // então a aplicação deverá restornar a porcentagem das mulheres entre 18 e 35.


            // Dado / Steup
            
            var exercises = new Exercises();
            var ears = 2;
            var dayCig = 10;
            var price = 7.0;

            // Quando / Ação 
            var returnedValues = exercises.Exercise7(ears, dayCig, price);

            // Deve / Asserções

            Assert.Equal(2555, returnedValues);         
        }
        [Theory]
        [InlineData(60, 3, true)]
        [InlineData(-54, -8, false)]
        public void should_return_true_when_passed_2_numbers_cousins_5_and_25(double x, double y, bool returned)
        {
            // Dado/Steup
            var exercises = new Exercises();

            // Quando/Ação
            var result = exercises.Exercise8(x , y);

            // Deve/Ações
            Assert.Equal(returned, result);
        }
        [Fact]
        public void Should_return_true_when_num1_bigger_sum_of_num2_and_num3()
        {
            // Dado - Steup
            var num1 = 4;
            var num2 = 2;
            var num3 = 1;
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise9(num1, num2, num3);

            Assert.Equal(true, result);

        }

        public void Should_return_the_higher_number_or_if_are_equals()
        {
            var a = 1.1;
            var b  = 1.2;
            var exercises = new Exercises();

            var result = exercises.Exercise10(a, b);

            Assert.Equal("b", result);
        }
        [Theory]
        [InlineData(2,2,0)]
        [InlineData(3,2,1)]
        [InlineData(7,3,1)]
        public void Should_retun_a(int num1, int num2, double soma)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise11(num1, num2);

            Assert.Equal(result, soma);
        }
        [Theory]
        [InlineData(new int[4]{1,2,3,4},6)]
        [InlineData(new int[4]{4,4,1,3},8)]
        [InlineData(new int[6]{2,2,2,2,2,7},10)]
        public void Should_return_the_sum_of_4_numbers_but_only_the_pairs(int[] num, int pares)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise12(num);

            Assert.Equal(result, pares);
        }

        [Theory]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10},10)]
        [InlineData(new int[10]{1,2,3,4,5,4,3,8,2,3},8)]
        public void Should_return_the_higher_number_between_10_numbers(int[] num, int maior)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise13(num);

            Assert.Equal(result, maior);
        }
        [Theory]
        [InlineData(new double[3]{3,2,1}, "1 < 2 < 3")]
        public void Should_return_crescent_order(double[] num, string ordem)
        {
            var exercises = new Exercises();

            string result = exercises.Exercise14(num.ToList());

            Assert.Equal(ordem, result);
        }

        //DADO que a aplicação está pronta, QUANDO o usuário informar 10 números 
        //DEVE retornar quantos são múltiplos de 3 e quantos são múltiplos de 5
        [Theory]
        [InlineData(new double[10]{56,45,23,22,33,12,10,45,55,16},4,2)]
        public void Should_return_how_many_multiples_of_3_and_5(double[] num, int mult3, int mult5)
        {
            var exercise = new Exercises();

            var result = exercise.Exercise15(num.ToList());
            (int, int) expected = (mult3, mult5);

            Assert.Equal(expected, result);    
        }

        //DADO que a aplicação esta pronta, QUANDO o usuário informar seu salário
        //DEVE retornar o salário líquido de acordo com os descontos
        [Theory]
        [InlineData(399.90, 399.90)]
        [InlineData(2000.01, 1400.007)]
        public void Should_return_the_liquid_pay_of_the_sale(double salario, double esperado)
        {
            var exercise = new Exercises();

            var result = exercise.Exercise16(salario);

            Assert.Equal(esperado, result);
        }

        [Theory]
        [InlineData(6, new int[10]{6,12,18,24,30,36,42,48,54,60})]
        [InlineData(5, new int[10]{5,10,15,20,25,30,35,40,45,50})]
        public void Should_return_6_multiplied_by_1_to_10_when_passed_6(int number, int[] expectedResult)
        {
            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            IEnumerable<int> result = exercises.Exercise17(number);

            // Deve / Asserções
            // Assert.Collection(
            //     result,
            //     item1 => { Assert.Equal(expectedResult[0], item1); },
            //     item2 => { Assert.Equal(expectedResult[1], item2); },
            //     item3 => { Assert.Equal(expectedResult[2], item3); },
            //     item4 => { Assert.Equal(expectedResult[3], item4); },
            //     item5 => { Assert.Equal(expectedResult[4], item5); },
            //     item6 => { Assert.Equal(expectedResult[5], item6); },
            //     item7 => { Assert.Equal(expectedResult[6], item7); },
            //     item8 => { Assert.Equal(expectedResult[7], item8); },
            //     item9 => { Assert.Equal(expectedResult[8], item9); },
            //     item10 => { Assert.Equal(expectedResult[9], item10); }
            // );


        }

        // [Theory]
        // [InlineData(5, new int[10]{5,10,15,20,25,30,35,40,45,50})]
        //DADO que a aplicação esteja pronta, QUANDO o usuário informar um número 
        //DEVE retornar a tabuada de 1 a 10
        // public void Should_return_the_number_multiplied_by_1_to_10(int number, int[] sum)
        // {
        //     var exercise = new Exercises();

        //     IEnumerable<int> resutl = exercise.ExerciseTest(number);

        // }

        [Theory]
        [InlineData(3, 3.90)]
        //DADO que a aplicação esta pronta, QUANDO o usuário impornar o total de maçãs que ele irá comprar 
        // DEVE retornar o custo total da compra.
        public void Should_return_the_total_purchase_cost(double quantidade, double expected)
        {
            var exercise = new Exercises();

            var result = exercise.Exercise18(quantidade);

            Assert.Equal(expected, result); 
            
        } 
    }
}
