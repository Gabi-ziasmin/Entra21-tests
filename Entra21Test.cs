using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Entra21_tests
{
    public class Entra21Test
    {
       public void Should_register_the_person_only_if_the_pssword_is_correct()
       {
           var exercise = new Entra21();
           var joao = ("João",16);
           var pessoa = new List<(string name, int age)>{joao};

           bool result = exercise.Cadastrar(pessoa, "Certo");

           Assert.Null(exercise.Pessoas); 
           Assert.True(result);
       }

       public void Should_not_register_the_person_if_the_pssword_is_incorrect()
       {
           var exercise = new Entra21();
           var ana = ("Ana", 15);
           var pessoa = new List<(string name, int age)>{ana};


           bool result = exercise.Cadastrar(pessoa, "Errado");

           Assert.Null(exercise.Pessoas);
           Assert.False(result);
       }
    }
}
