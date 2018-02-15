using System;
namespace daoMangasAmis
{
    public class DaoFactory
    {
        static private IMangaDao mangaDao;
        private DaoFactory()
        {
            throw new Exception("Does not instanciate");
        }
        static public IMangaDao MangaDao(){
            if (mangaDao is null)
                mangaDao = new MangaDao();
            return mangaDao;
        }

        private void fakemain()
        {
            DaoFactory.MangaDao().Load();
            foreach(Manga manga in DaoFactory.MangaDao().FindAll()){
                Console.WriteLine(manga);
            }
            Manga m = new Manga();
            DaoFactory.MangaDao().CreateManga(m);
        }
    }
}
