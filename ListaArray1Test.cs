using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Entra21_tests
{
    public class ListaArray1Test
    {
        // Dado que a aplicação está preparada. Quando o usuário chamar informar 4 números no Array A e 4 números no Array B,
        // então a aplicação deverá restornar A menos B.
        [Theory]
        [InlineData(new int[4]{2,2,2,2},new int[4]{2,2,2,2}, new int[4]{0,0,0,0})]
        public void Should_return_A_minus_B(int[] A, int[] B, int[] Expected)
        {
            var listaA1 = new ListaArray1();
            IEnumerable<int> result = listaA1.ExerciseTest(A,B); 

            Assert.Equal(Expected, result);     
        }
    }
}
