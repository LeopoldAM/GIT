using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Salaire { get; set; }

        public Employe() { }

        public Employe(string nom, string prenom,  int salaire)
        {
            
            Nom = nom;
            Prenom = prenom;
            Salaire = salaire;
        }

        public override string ToString()
        {
            return $"Nom: {Nom}, Prénom: {Prenom}, Id: {Id} , Salaire: {Salaire}";
        }

    }
}
