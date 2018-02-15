using DesignPatternModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEmploye
{
    class BusinessEmploye
    {
        public static Employe AddEmploye(Employe employe)
        {
            return LocalStorage.AddEmploye(employe);
        }

        public Employe GetEmploye(int id)
        {
            return LocalStorage.GetEmploye(id);

        }

        public float GetSommeSalaire()
        {
            return LocalStorage.GetSommeSalaire();
        }
    }
}
