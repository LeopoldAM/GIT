using DesignPatternModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntreprise
{
    class BusinessEntreprise
    {
        public List<Employe> ListEmploye()
        {
            return LocalStorage.ListEmploye();
        }
    }
}
