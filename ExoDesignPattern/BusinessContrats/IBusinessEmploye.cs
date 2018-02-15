using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessContrats
{
    public interface IBusinessEmploye
    {
        Employe AddEmploye(Employe employe);

        Employe GetEmploye(int id);

        float GetSommeSalaire();
    }
}
