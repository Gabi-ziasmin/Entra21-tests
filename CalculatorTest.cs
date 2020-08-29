using System;
using Xunit;

namespace Entra21_tests
{
    public class CaculatorTest
    {
        [Fact]
        public void should_return_8_whem_passed_minus_2_and_2()
        {
            var firstNumber = 2;
            var secondNumber = 2;
            var calculator = new Caculator();

            var result = calculator.Divide(firstNumber, secondNumber);

            var expectedOutpt = 1;
            Assert.Equal(expectedOutpt, result);
        }
    }
}
