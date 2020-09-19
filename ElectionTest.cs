using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Entra21_tests
{
    public class ElectionTest
    {
        [Fact]
        private void Should_create_candidates_whem_passed_is_incorrect(Double[] womenAge, int expectedValue)
        {
            var election = new Election();
            var candidates = new List<(int id, string name)>{(1, "José")};

            var created = election.CreateCandidates(candidates, "Incorrect");

            Assert.False(created);
        }   

        [Fact]
        private void Should_create_candidates_whem_passed_is_correct(Double[] womenAge, int expectedValue)
        {
            var election = new Election();
            var candidates = new List<(int id, string name)>{(1, "José")};

            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            Assert.True(created);
        }  
    }
}
