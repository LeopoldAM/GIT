using BusinessContrats;
using DesignPatternBusiness;
using DesignPatternController;
using Entities;
using Repository;
using RepositoryContrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using static System.Console;

namespace ExoDesignPattern
{
    class Program
    {


        static void Main(string[] args)
        {
            Choix();
        }

        public static int Menu()
        {
            WriteLine("1. Ajouter un employé");
            WriteLine("2. Liste id et noms");
            WriteLine("3. Récupérer personne à partir d'un id");
            WriteLine("4. Somme des salaires");
            return int.Parse(ReadLine());
        }

        public static void Choix()
        {
            // Créer le container Unity
            IUnityContainer unitycontainer = new UnityContainer();
            // Lie les implémentations aux interfaces correspondantes
            unitycontainer.RegisterType<IBusinessEmploye, BusinessEmploye>();
            unitycontainer.RegisterType<IBusinessEntreprise, BusinessEntreprise>();
            unitycontainer.RegisterType<IStorage, LocalStorage>();

            //instanciation des objets ,façon Unity avec les classes correspondantes, qu'on va utiliser par la suite
            //Une autre façon de récupérer une implémentation est via le container directement (utile pour notre
            //méthode Main de l’application console)
            EntrepriseController entrepriseController = unitycontainer.Resolve<EntrepriseController>();
            EmployeController employeController = unitycontainer.Resolve<EmployeController>();


            var saisie = Menu();

            while (saisie != 0)
            {
                switch (saisie)
                {
                    case 1:
                        WriteLine("nom : ");
                        string nom = ReadLine();
                        WriteLine("prenom : ");
                        string prenom = ReadLine();
                        WriteLine("salaire : ");
                        int salaire = int.Parse(ReadLine());
                        // traitement dans la vue (valeures rentrées en console) => appel du controller 
                        //=> fonction dans le LocalStorage =>> tout ça revient dans la vue !
                        Employe employe = employeController.AddEmploye(nom, prenom, salaire); 
                        WriteLine("employé ajouté " + employe);
                        ReadLine();

                        break;
                    case 2:
                        //fonctionne comme un foreach "string.Join()"
                        WriteLine(string.Join("\n", entrepriseController.ListEmploye()));
                        ReadLine();
                        break;
                    case 3:
                        WriteLine("id : ");
                        int id = int.Parse(ReadLine());
                        //appel du controller spécifique dans la vue
                        WriteLine(employeController.GetEmploye(id));
                        ReadLine();
                        break;
                    case 4:
                        //appel du controller spécifique dans la vue
                        WriteLine(employeController.GetSommeSalaire());
                        ReadLine();
                        break;


                }
                saisie = Menu();
            }
        }
    }
}

