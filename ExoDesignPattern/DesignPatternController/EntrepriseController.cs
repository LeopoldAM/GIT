using BusinessContrats;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternController
{
    public class EntrepriseController
    {
        
        //Le constructeur sera appelé automatiquement avec la variable bien renseigné en fonction de
        //l’implémentation de IStorage fournis pendant la création du container.

        IBusinessEntreprise BusinessEntreprise { get; }
        public EntrepriseController(IBusinessEntreprise businessEntreprise)
        {
            BusinessEntreprise = businessEntreprise;
        }

        public List<Employe> ListEmploye()
        {
            //appel listEmploye de IBusinessEntreprise
            return BusinessEntreprise.ListEmploye();
        }  
    }
}
