using Entities;
using RepositoryContrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternBusinessTests
{
    //pour le test 
    public class MockStorage : IStorage
    {
        public Employe AddEmploye(Employe employe)
        {
            throw new NotImplementedException();
        }

        public Employe GetEmploye(int id)
        {
            throw new NotImplementedException();
        }

        public float GetSommeSalaire()
        {
            return 10;
        }

        public List<Employe> ListEmploye()
        {
            throw new NotImplementedException();
        }
    }
}
