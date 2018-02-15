using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternModels
{
    public class Entreprise
    {
        public string Nom { get; set; }
        public List<Employe> Employees { get; set; }

        public Entreprise() { }

        public override string ToString()
        {
            return $"Entreprise : {Nom} , Liste d'employés : {Employees}";
        }
    }
}
