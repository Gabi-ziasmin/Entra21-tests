using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Entra21_tests
{
    public class Election
    { 
        //ToDo: should assert candidates list is empy
        public bool CreateCandidates(List<(int id, string name)> candidates, string password)
        {
            if (password == "Pa$$w0rd")
            {
                //Criar candidatos
                var myCandidates = candidates;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetCandidates(List<(int id, string name)> candidates, string password)
        {
            
        }
    } 
    
}
