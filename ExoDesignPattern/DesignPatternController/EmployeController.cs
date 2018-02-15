using BusinessContrats;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternController
{
    public class EmployeController
    {

        //constructeur spécifique à unity
        //Le constructeur sera appelé automatiquement avec la variable bien renseigné en fonction de
        //l’implémentation de IStorage fournis pendant la création du container.
        //Une autre façon de récupérer une implémentation est via le container directement (utile pour notre
        //méthode Main de l’application console)
        //EntrepriseController entrepriseController=unitycontainer.Resolve<EntrepriseController>();

        IBusinessEmploye BusinessEmploye { get; }
        public EmployeController(IBusinessEmploye businessEmploye)
        {
            BusinessEmploye = businessEmploye;
        }

        public Employe AddEmploye(string nom, string prenom, int salaire)
        {
            
            Employe employe = new Employe(nom, prenom, salaire);
            return BusinessEmploye.AddEmploye(employe);

        }

        public Employe GetEmploye(int id)
        {
            
            return BusinessEmploye.GetEmploye(id);
            
        }

        public float GetSommeSalaire()
        {
            
            return BusinessEmploye.GetSommeSalaire();
        }
    }
}
