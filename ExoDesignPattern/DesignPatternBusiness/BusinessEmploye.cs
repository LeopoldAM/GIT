using BusinessContrats;
using Entities;
using RepositoryContrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternBusiness
{
    public class BusinessEmploye : IBusinessEmploye
    {

        IStorage Storage { get; }
        public BusinessEmploye(IStorage storage)
        {
            Storage = storage;
        }

        public Employe AddEmploye(Employe employe)
        {
            return Storage.AddEmploye(employe);
        }

        public Employe GetEmploye(int id)
        {
            return Storage.GetEmploye(id);
        }

        public float GetSommeSalaire()
        {
            return Storage.GetSommeSalaire();
        }
    }
}
