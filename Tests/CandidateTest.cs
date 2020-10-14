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

            Assert.NotEqual(Jose.Id, Ana.Id);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("000.000.000-00")]
        [InlineData("677.A54.665-96")]
        [InlineData("6684555954")]
        [InlineData("455551112458")]
        [InlineData("2111544451F")]
        public void Should_return_false_when_CPF_is_incorrect(string Cpf)
        {
            var Jose = new Candidate("José", Cpf);

            var isNotValid = Jose.Validate();

            Assert.False(isNotValid);
        }

        [Theory]
        [InlineData("089.511.540-92")]
        [InlineData("09026054963")]
        [InlineData("67770444934")]
        [InlineData("95363306018")]
        [InlineData("122.324.730-90")]
        public void Should_return_true_when_CPF_is_correct(string Cpf)
        {
            var Ana = new Candidate("Ana", Cpf);

            var isValid = Ana.Validate();

            Assert.True(isValid);
        }

        [Theory]
        [InlineData("Joao2")]
        [InlineData("#Joao")]
        [InlineData("")]
        [InlineData(null)]
        public void Should_return_false_when_Name_is_incorrect(string Name)
        {
            var candidateName = new Candidate(Name, "09026054963");

            var isNotValid = candidateName.Validate();

            Assert.False(isNotValid);
        }

        [Theory]
        [InlineData("João")]
        [InlineData("Ana")]
        [InlineData("Maria Julia")]
        public void Should_return_ture_when_Name_is_correct(string Name)
        {
            var candidateName = new Candidate(Name, "09026054963");

            var isNotValid = candidateName.Validate();

            Assert.True(isNotValid);
        }

        
    }
}