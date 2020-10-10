using System.Collections.Generic;
using System.Linq;
using Domain;
using Xunit;

namespace Tests
{
    public class ElectionTest
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            var jose = new Candidate("José", "25165898485");
            var candidates = new List<Candidate>{jose};

            // Quando / Ação
            var created = election.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
            Assert.False(created);
            Assert.Empty(election.Candidates);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            var jose = new Candidate("José", "25165898485");
            var candidates = new List<Candidate>{jose};

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // Deve / Asserções
            Assert.True(created);
            
            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal(jose.Id, election.Candidates.ElementAt(0).Id);
        }

        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            var jose = new Candidate("José", "25165898485");
            var ana = new Candidate("Ana", "56525148452");
            var candidates = new List<Candidate>{jose, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            var candidateJose = election.GetCandidatesByName(jose.Name);
            var candidateAna = election.GetCandidatesByName(ana.Name);

            // Deve / Asserções
            Assert.NotEqual(candidateAna, candidateJose);
        }

        [Fact]
        public void should_vote_twice_in_candidate_Fernando()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var fernando = new Candidate("Fernando","56558445754");
            var ana = new Candidate("Ana","65626532659");
            var candidates = new List<Candidate>{fernando, ana};

            election.CreateCandidates(candidates, "Pa$$w0rd");

            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(fernando.Cpf);
            election.Vote(fernando.Cpf);

            // Deve / Asserções
            var candidateFernando = election.Candidates.First(x => x.Id == fernando.Id);
            var candidateAna = election.Candidates.First(x => x.Id == ana.Id);
            Assert.Equal(2, candidateFernando.Votes);
            Assert.Equal(0, candidateAna.Votes);
        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var fernando = new Candidate("Fernando","56558445754");
            var ana = new Candidate("Ana","65626532659");
            var candidates = new List<Candidate>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var anaId = election.GetCandidateIdByCPF(ana.Cpf);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(ana.Cpf);
            election.Vote(ana.Cpf);
            var winners = election.GetWinners();

            // Deve / Asserções
            Assert.Equal(1, winners.Count);
            Assert.Equal(anaId, winners[0].Id);
            Assert.Equal(2, winners[0].Votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var fernando = new Candidate("Fernando","56558445754");
            var ana = new Candidate("Ana","65626532659");
            var candidates = new List<Candidate>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoId = election.GetCandidateIdByCPF(fernando.Cpf);
            var anaId = election.GetCandidateIdByCPF(ana.Cpf);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(ana.Cpf);
            election.Vote(fernando.Cpf);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateFernando = winners.Find(x => x.Id == fernandoId);
            var candidateAna = winners.Find(x => x.Id == anaId);
            Assert.Equal(1, candidateFernando.Votes);
            Assert.Equal(1, candidateAna.Votes);
        }

        [Fact]
        public void should_return_candidates_id_when_CPF_is_correct()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var fernando = new Candidate("Fernando","56558445754");
            var ana = new Candidate("Ana","65626532659");
            var candidates = new List<Candidate>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoCPF = election.GetCandidateIdByCPF(fernando.Cpf);//Fernando
            var anaCPF = election.GetCandidateIdByCPF(ana.Cpf);//Ana
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(ana.Cpf);
            election.Vote(fernando.Cpf);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateFernando = winners.Find(x => x.Id == fernandoCPF);
            var candidateAna = winners.Find(x => x.Id == anaCPF);
            Assert.Equal("56558445754", candidateFernando.Cpf);
            Assert.Equal("65626532659", candidateAna.Cpf);
        }
    }
}