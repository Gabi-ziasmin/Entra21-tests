using System.Collections.Generic;
using System.Linq;
using Domain;
using Xunit;

namespace Tests
{
    public class CandidateTest
    {
        [Fact]
        public void Should_contains_same_parameters_provided()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";
            
            var candidate = new Candidate(name, CPF);

            Assert.Equal(name, candidate.Name);
            Assert.Equal(CPF, candidate.Cpf);
        }

        [Fact]
        public void Should_contain_votes_equals_2_when_voted_twice()
        {
            var name = "Ana Maria Braga";
            var CPF = "976.374.020-70";
            var candidate = new Candidate(name, CPF);

            candidate.Vote();
            candidate.Vote();

            Assert.Equal(2, candidate.Votes);          
        }

        [Fact]
        public void Should_not_generate_same_id_for_both_candidates()
        {
            var Jose = new Candidate("José", "623.044.330-90");
            var Ana = new Candidate("Ana", "279.694.260-00");
        }

    }
}