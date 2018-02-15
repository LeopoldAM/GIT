using System;
using System.Collections.Generic;

namespace daoMangasAmis
{
    public interface IMangaDao
    {
        // pour l'enregistrement en fichier
        List<Manga> Load();
        void Save();
        // pour les manipulations
        bool CreateManga(Manga manga);
        List<Manga> FindAll();
        List<Manga> FindAllLent();
        List<Manga> FindAllGiven();
        List<Manga> FindAllMy();
        bool updateManga(Manga manga);
        bool deleteManga(Manga manga);
    }
}
