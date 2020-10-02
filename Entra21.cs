using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Entra21_tests
{
    public class Entra21
    {
        private List<(Guid id, string name, int age, string CPF)> pessoas { get; set; }

        public IReadOnlyCollection<(Guid id, string name, int age, string CPF)> Pessoas => pessoas;
        public bool Cadastrar(List<(string name, int age)> people, string password)
        {
            if (password == "Certo")
            {                
                pessoas = people.Select(x => {
                    return (x.name, x.age);
                }).ToList();

                return true;
            }
            else
            {
                return false;
            }
        }
    }          
}   
