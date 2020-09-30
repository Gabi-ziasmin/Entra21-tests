using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Entra21_tests
{
    public class ListaArray1
    {
       public int[] Exercise1(int[] A, int[] B)
       {
           var C =  new int[4];
           for (int i = 0; i < 4; i++)
           {
               C.Select(Item => A[i] - B[i]);
           }

           return C;
       }

       public IEnumerable<int> Exercise2(int[] num)
       {
            return num.Reverse();
       }

    //    public bool Exercise3(int[] A, int num)
    //    {
    //        for (int i = 0; i < A.Length; i++)
    //        {
    //             return (A[i] == num ? true: false);                
    //        }

    //    }

    }          
}   
