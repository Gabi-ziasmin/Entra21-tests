using System;
using System.Collections.Generic;
using System.Linq;

namespace Entra21_tests
{
    public class Election
    {
    
        // Propriedade abaixo:
        // Sempre em PascalCase
        public List<(Guid id, string name, int votes, string CPF)> Candidates { get; private set; }
        public bool CreateCandidates(List<(string nome, string CPF)> candidates, string password)
        {
            if (password == "Pa$$w0rd")
            {
                Candidates = candidates.Select(candidate => {
                    return (Guid.NewGuid(), candidate.nome, 0, candidate.CPF);
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
                Candidates = Candidates.Select(candidate => {
                return candidate.id == id
                    ? (candidate.id, candidate.name, candidate.votes + 1, candidate.CPF)
                    : candidate;
            }).ToList();
        }

        public List<(Guid id, string name, int votes, string CPF)> GetWinners()
        {
            var winners = new List<(Guid id, string name, int votes, string CPF)>{Candidates[0]};

            for (int i = 1; i < Candidates.Count; i++)
            {
                if (Candidates[i].votes > winners[0].votes)
                {
                    winners.Clear();
                    winners.Add(Candidates[i]);
                }
                else if (Candidates[i].votes == winners[0].votes)
                {
                    winners.Add(Candidates[i]);
                }
            }
            return winners;
        }
    }
}