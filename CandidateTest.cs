using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Entra21_tests
{
    public class CandidateTest
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            var candidate = ("José", "25165898485");
            var candidates = new List<(string name, string CPF)>{candidate};

            // Quando / Ação
            var created = election.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
            Assert.Empty(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            var candidate = ("José", "25165898485");
            var candidates = new List<(string name, string CPF)>{candidate};

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // Deve / Asserções
            Assert.True(created);
            
            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal(candidate.Item1, election.Candidates.ElementAt(0).name);
        }

        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            var Jose = ("José", "25165898485");
            var Ana = ("Ana", "56525148452");
            var candidates = new List<(string name, string CPF)>{Jose, Ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            var candidateJose = election.GetCandidatesByName(Jose.Item1);
            var candidateAna = election.GetCandidatesByName(Ana.Item2);

            // Deve / Asserções
            Assert.NotEqual(candidateAna, candidateJose);
        }

        [Fact]
        public void should_vote_twice_in_candidate_Fernando()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var Fernando = ("Fernando","56558445754");
            var Ana = ("Ana","65626532659");
            var candidates = new List<(string name, string CPF)>{Fernando, Ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoId = election.GetCandidateIdByCPF(Fernando.Item2);
            var anaId = election.GetCandidateIdByCPF(Ana.Item2);

            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(fernandoId);
            election.Vote(fernandoId);

            // Deve / Asserções
            var candidateFernando = election.Candidates.First(x => x.id == fernandoId);
            var candidateAna = election.Candidates.First(x => x.id == anaId);
            Assert.Equal(2, candidateFernando.votes);
            Assert.Equal(0, candidateAna.votes);
        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var fernando = ("Fernando","56558445754");
            var Ana = ("Ana","65626532659");
            var candidates = new List<(string name, string CPF)>{fernando, Ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var anaId = election.GetCandidateIdByCPF(Ana.Item2);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaId);
            election.Vote(anaId);
            var winners = election.GetWinners();

            // Deve / Asserções
            Assert.Equal(1, winners.Count);
            Assert.Equal(anaId, winners[0].id);
            Assert.Equal(2, winners[0].votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var Fernando = ("Fernando","56558445754");
            var Ana = ("Ana","65626532659");
            var candidates = new List<(string name, string CPF)>{Fernando, Ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoId = election.GetCandidateIdByCPF(Fernando.Item2);
            var anaId = election.GetCandidateIdByCPF(Ana.Item2);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaId);
            election.Vote(fernandoId);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateFernando = winners.Find(x => x.id == fernandoId);
            var candidateAna = winners.Find(x => x.id == anaId);
            Assert.Equal(1, candidateFernando.votes);
            Assert.Equal(1, candidateAna.votes);
        }

        [Fact]
        public void should_return_candidates_id_when_CPF_is_correct()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var Fernando = ("Fernando","56558445754");
            var Ana = ("Ana","65626532659");
            var candidates = new List<(string name, string CPF)>{Fernando, Ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoCPF = election.GetCandidateIdByCPF(Fernando.Item2);//Fernando
            var anaCPF = election.GetCandidateIdByCPF(Ana.Item2);//Ana
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaCPF);
            election.Vote(fernandoCPF);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateFernando = winners.Find(x => x.id == fernandoCPF);
            var candidateAna = winners.Find(x => x.id == anaCPF);
            Assert.Equal("56558445754", candidateFernando.CPF);
            Assert.Equal("65626532659", candidateAna.CPF);
        }
    }
}