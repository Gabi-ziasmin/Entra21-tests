using System;
using System.Collections.Generic;

namespace Entra21_tests
{
    public class Candidate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public int Votos { get; set; }

        public Candidate(string nome, string cpf)
        {
        }

    }
}