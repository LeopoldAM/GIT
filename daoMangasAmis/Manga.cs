using System;
namespace daoMangasAmis
{
    [Serializable]
    public class Manga
    {
        private readonly int id;
        public int ID { get { return id; } }
        public int Volume { get; set; }
        public string Titre { get; set; }
        public bool Lent { get; set; }
        public bool Given { get; set; }
        public DateTime When { get; set; }

        public  Manga(){}
        public Manga(int i, int volume, string titre)
        {
            id = i;
            Volume = volume;
            Titre = titre;
        }
        public Manga(int volume, string titre)
        {
            Volume = volume;
            Titre = titre;
        }
        public override bool Equals(object obj)
        {
            if(!(obj is null) && obj is Manga)
            {
                if (Volume == ((Manga)obj).Volume && Titre.Equals(((Manga)obj).Titre))
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
            return string.Format("[Manga: ID={0}, Volume={1}, Titre={2}]", ID, Volume, Titre);
        }
        public void Copy(Manga manga)
        {
            Volume = manga.Volume;
            Titre = manga.Titre;
            Given = manga.Given;
            When = manga.When;
            Lent = manga.Lent;
        }


    }
}
