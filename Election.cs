using System;
using System.Collections.Generic;
using System.Linq;

namespace Entra21_tests
{
    public class Election
    {  
        // Propriedade abaixo:
        // Sempre em PascalCase
        private List<Candidate> candidates { get; set; }

        public IReadOnlyCollection<(Guid id, string name, int votes, string CPF)> Candidates => candidates;

        public Election()
        {
            var candi = new Candidate();
            candidates = new List<(Guid id, string name, int votes, string CPF)>{};
        }

        public bool CreateCandidates(List<(string name, string CPF)> candidate, string password)
        {
            if (password == "Pa$$w0rd")
            {
                if (candidates == null )
            {
                return true;
            }
                candidates = candidate.Select(x => {
                    return (Guid.NewGuid(), x.name, 0, x.CPF);
                }).ToList();

                return true;
            }
            else
            {
                return false;
            }
        }

        // ToDo: Criar método que retorne um Guid que represente o candidato pesquisado por CPF

        // ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado
        public List<(Guid id, string name, int votes, string CPF)> GetCandidatesByName(string name)
        {
            return Candidates.Where(x => x.name == name).ToList();
        }

        public Guid GetCandidateIdByCPF(string CPF)
        {
            return Candidates.First(x => x.CPF == CPF).id;
        }

        public void Vote(Guid id)
        {
                candidates = Candidates.Select(candidate => {
                return candidate.id == id
                    ? (candidate.id, candidate.name, candidate.votes + 1, candidate.CPF)
                    : candidate;
            }).ToList();
        }

        public List<(Guid id, string name, int votes, string CPF)> GetWinners()
        {
            var winners = new List<(Guid id, string name, int votes, string CPF)>{candidates[0]};

            for (int i = 1; i < Candidates.Count; i++)
            {
                if (candidates[i].votes > winners[0].votes)
                {
                    winners.Clear();
                    winners.Add(candidates[i]);
                }
                else if (candidates[i].votes == winners[0].votes)
                {
                    winners.Add(candidates[i]);
                }
            }
            return winners;
        }
    }
}