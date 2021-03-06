using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Election
    {  
        // Propriedade abaixo:
        // Sempre em PascalCase
        private List<Candidate> candidates { get; set; }

        public IReadOnlyCollection<Candidate> Candidates => candidates;

        public Election()
        {
            candidates = new List<Candidate>();
        }
        public bool CreateCandidates(List<(string name, string cpf)> candidate, string password)
        {
            if (password == "Pa$$w0rd")
            {
                candidates = candidate.Select(x => {
                    return new Candidate(x.name, x.cpf);
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
        public List<Candidate> GetCandidatesByName(string name)
        {
            return Candidates.Where(x => x.Name == name).ToList();
        }

        public Guid GetCandidateIdByCPF(string cpf)
        {
            return Candidates.First(x => x.Cpf == cpf).Id;
        }

        public void Vote(Guid id)
        {
            var foundCandidate = candidates.Find(x => x.Id == id);
            foundCandidate.Votes++;
        }

        public List<Candidate> GetWinners()
        {
            var winners = new List<Candidate>{candidates[0]};

            for (int i = 1; i < Candidates.Count; i++)
            {
                if (candidates[i].Votes > winners[0].Votes)
                {
                    winners.Clear();
                    winners.Add(candidates[i]);
                }
                else if (candidates[i].Votes == winners[0].Votes)
                {
                    winners.Add(candidates[i]);
                }
            }
            return winners;
        }
    }
}