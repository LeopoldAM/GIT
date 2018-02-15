using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternModels
{
    public class LocalStorage
    {
        public static int id = 10;
        private static List<Employe> employees = new List<Employe>();

        public static Employe AddEmploye(Employe employe)
        {
            //Gestion d'un id  auto-généré
            employe.Id = id++;

            employees.Add(employe);

            return employe;
        }

        public static Employe GetEmploye(int id)
        {
            Employe ById = employees.FirstOrDefault(e => e.Id == id);
            return ById;
        }

        public static float GetSommeSalaire()
        {
            float res = employees.Sum(e => e.Salaire);
            return res;
        }

        public static List<Employe> ListEmploye()
        {
            return employees;
        }
    }
}
