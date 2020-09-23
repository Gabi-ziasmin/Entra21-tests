using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Entra21_tests
{
    public class ListaArray1
    {
       public int[] ExerciseTest(int[] A, int[] B)
       {
           var C =  new int[4];
           for (int i = 0; i < 4; i++)
           {
               C.Select(Item => A[i] - B[i]);
           }

           return C;
       }
    }          
}   
