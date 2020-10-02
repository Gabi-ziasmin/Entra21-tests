using System;
using System.Collections.Generic;

namespace Entra21_tests
{
    public class Candidate
    {
        private List<(Guid id, string name, int votes, string CPF)> candidates { get; set; }
        public IReadOnlyCollection<(Guid id, string name, int votes, string CPF)> CandidatesReadOnly => candidates;

        internal static object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}