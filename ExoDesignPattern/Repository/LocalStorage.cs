using Entities;
using RepositoryContrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
    public class LocalStorage : IStorage
    {
        public static int id = 10;
        private static List<Employe> employees = new List<Employe>();

        public Employe AddEmploye(Employe employe)
        {
            //Gestion d'un id  auto-généré
            employe.Id = id++;

            employees.Add(employe);

            return employe;
        }

        public Employe GetEmploye(int id)
        {
            Employe ById = employees.FirstOrDefault(e => e.Id == id);
            return ById;
        }

        public float GetSommeSalaire()
        {
            float res = employees.Sum(e => e.Salaire);
            return res;
        }

        public List<Employe> ListEmploye()
        {
            return employees;
        }
    }
}
