using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Entra21_tests
{
    public class Entra21
    {
        private List<(string name, int age)> pessoas { get; set; }

        public IReadOnlyCollection<(string name, int age)> Pessoas => pessoas;
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

        public List<(string name, int age)> Buscar(string name)
        {
            return pessoas.Where(x => x.name == name).ToList();
        }
    }          
}   
