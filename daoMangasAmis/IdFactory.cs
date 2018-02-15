using System;
using System.Linq;
namespace daoMangasAmis
{
    public class IdFactory
    {
        private IdFactory()
        {
            throw new Exception("Does not instanciate");
        }
        static public int GetNextIdManga()
        {
            if(!(DaoFactory.MangaDao().FindAll() is null) 
               && DaoFactory.MangaDao().FindAll().Count != 0)
            {
                return 1 + DaoFactory.MangaDao().
                                     FindAll().
                                     OrderByDescending(m => m.ID).
                                     First().ID;
            }
            return 1;
        }

    }
}
