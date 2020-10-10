using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Xunit;

namespace Tests
{
    public class ListaArray1Test 
    {
        // Dado que a aplicação está preparada. Quando o usuário chamar informar 4 números no Array A e 4 números no Array B,
        // então a aplicação deverá restornar A menos B.
        [Theory]
        [InlineData(new int[4]{2,2,2,2},new int[4]{2,2,2,2}, new int[4]{0,0,0,0})]
        public void Should_return_A_minus_B(int[] A, int[] B, int[] expected)
        {
            var listaA1 = new ListaArray1();
            IEnumerable<int> result = listaA1.Exercise1(A,B);      

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_return_10_values_in_direct_and_reverse_order()
        {    
           var num = new int[10]{1,2,3,4,5,6,7,8,9,10};
           var listaA1 = new ListaArray1();
           IEnumerable<int> result = listaA1.Exercise2(num);

           Assert.Equal(num, num);
           Assert.Equal(new int[10]{10,9,8,7,6,5,4,3,2,1}, result);
        }

        [Fact]
        public void Should_return_the_solicited_number()
        {
            var listaA1 = new ListaArray1();
            var A = new int[3]{1,2,3};

            var result = listaA1.Exercise3(A, 3);

            Assert.True(result);
        }

        [Fact]
        //DADO que a aplicação está pronta, QUANDO o usuário informar dois arrays com 10 valores
        //DEVE retornar se os mesmos são iguais ou diferentes  
        public void Should_return_if_is_equal_or_diferent()
        {
            var listaA1 = new ListaArray1();
            var A = new int[3]{1,2,3};
            var B = new int[3]{1,2,3};

            var result = listaA1.Exercise4(A, B);

            Assert.True(result);
        }

       [Theory]
       [InlineData(new int[5]{3,3,3,3,3}, 3.0)]
       public void Should_return_the_avarage_of_5_numbers(int[] A, double expected)
       {
           var listaA1 = new ListaArray1();

           var result = listaA1.Exercise5(A);

           Assert.Equal(expected, result);
       }

    //    [Theory]
    //    [InlineData(new int[4]{4,3,2,1}, new int[4]{1,2,3,4}, new int[4]{5,5,5,5})]
    //    public void Should_return_the_sum_of_A_and_B( int[] A, int [] B, int[] expectedArray )
    //    {
    //        var listaA1 = new ListaArray1();

    //        var result = listaA1.Exercise6(A,B);

    //        Assert.Equal(expectedArray, result);
    //    }

    }
}
