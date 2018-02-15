using System;
using System.Collections.Generic;
namespace daoMangasAmis
{
    [Serializable]
    public class Ami
    {
        private readonly int id;
        public int ID { get { return id; } }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Surnom { get; set; }
        public List<Manga> Mangas { get; set; }

        public Ami()
        {
            Mangas = new List<Manga>();
        }
        public Ami(int i, string nom, string  prenom, string surnom)
        {
            id = i;
            Nom = nom;
            Prenom = prenom;
            Surnom = surnom;
            Mangas = new List<Manga>();
        }
        public Ami(string nom, string prenom, string surnom)
        {
            Nom = nom;
            Prenom = prenom;
            Surnom = surnom;
            Mangas = new List<Manga>();
        }

        public override bool Equals(object obj)
        {
            if(obj is Ami)
            {
                Ami a = (Ami)obj;
                if (a.Nom.Equals(Nom) && a.Prenom.Equals(Prenom) && a.Surnom.Equals(Surnom))
                    return true;
            }
            return false;
        }
        
         public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
         public override string ToString()
        {
            return string.Format("[Ami: ID={0}, Nom={1}, Prenom={2}, Surnom={3}, Mangas={4}]", ID, Nom, Prenom, Surnom, Mangas);
        }

        public void addManga(Manga manga)
        {
            Mangas.Add(manga);
        }
    }
}
