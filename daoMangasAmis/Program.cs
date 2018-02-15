using System;

namespace daoMangasAmis
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            //Manga manga = new Manga(3, "manga");
            //DaoFactory.MangaDao().CreateManga(manga);
            //foreach (Manga m in DaoFactory.MangaDao().FindAll())
                Console.WriteLine(DaoFactory.MangaDao());
            Finish();
        }

        static void Start()
        {
            DaoFactory.MangaDao().Load();
        }
        static void Finish()
        {
            DaoFactory.MangaDao().Save();
        }
    }
}
