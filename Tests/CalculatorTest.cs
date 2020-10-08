
using System;
using Domain;
using Xunit;

namespace Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(3,3,6)]
        public void should_return_the_result_of_the_sum_between_2_parameters(double firstNumber, double secondNumber, double expectedOutpt)
        {
            var calculator = new Calculator();

            var result = calculator.Sum(firstNumber, secondNumber);

            Assert.Equal(expectedOutpt, result);
        }

        [Theory]
        [InlineData(new double[5]{15,18,35,20,11}, 60)]
        [InlineData(new double[5]{15,13,11,40,11}, 0)]
        public void should_return(double[] womenAge, double porcent)
        {
            var calculator = new Calculator();
            
            var result = calculator.Test(womenAge);

            Assert.Equal(result, porcent);
        }
    }
}
