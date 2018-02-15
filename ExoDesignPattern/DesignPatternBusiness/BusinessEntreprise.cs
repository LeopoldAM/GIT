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
    public class BusinessEntreprise : IBusinessEntreprise
    {
       
        //Le constructeur sera appelé automatiquement avec la variable bien renseigné en fonction de
        //l’implémentation de IStorage fournis pendant la création du container.
        IStorage Storage { get; }
        public BusinessEntreprise(IStorage storage)
        {
            Storage = storage;
        } 

        public List<Employe> ListEmploye()
        {    
            //appel ListEmploye de IStorage
            return Storage.ListEmploye();
        }
    }
}
