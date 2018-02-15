using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace daoMangasAmis
{
    public class MangaDao : IMangaDao
    {
        private readonly string fileName = "/Users/Ludivine/mangas.bin";
        public List<Manga> Mangas { get; set; }

        public MangaDao(){}

        public bool CreateManga(Manga manga)
        {
            try
            {
                Manga newManga = new Manga(IdFactory.GetNextIdManga(), manga.Volume, manga.Titre);
                FindAll().Add(newManga);
            }
            catch(Exception e)
            {
                Console.WriteLine("OUPS...");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;

        }

        public bool deleteManga(Manga manga)
        {
            try
            {
                Mangas.Remove(manga);
            }
            catch (Exception e)
            {
                Console.WriteLine("OUPS...");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;
        }

        public List<Manga> FindAll()
        {
            if (Mangas is null)
                Load();
            return Mangas;
        }

        public List<Manga> FindAllGiven()
        {
            if (Mangas is null)
                Load();
            return Mangas.FindAll(m => m.Given);
        }

        public List<Manga> FindAllLent()
        {
            if (Mangas is null)
                Load();
            return Mangas.FindAll(m => m.Lent);
        }

        public List<Manga> FindAllMy()
        {
            if (Mangas is null)
                Load();
            return Mangas.FindAll(m => m.Given == false && !m.Lent);
        }

        public List<Manga> Load()
        {
            FileStream fileStream = null;
            BinaryFormatter binaryFormatter = null;
            try
            {
                using (fileStream = File.Open(fileName, FileMode.Open))
                {
                    binaryFormatter = new BinaryFormatter();
                    Mangas = 
                        (List<Manga>)binaryFormatter.
                        Deserialize(fileStream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OUPS...");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Mangas =  new List<Manga>();
            }
            return Mangas;
        }

        public void Save()
        {
            FileStream fileStream = null;
            BinaryFormatter binaryFormatter = null;
            try
            {
                using (fileStream = File.Create(fileName))
                {
                    binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, Mangas);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OUPS...");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        public override string ToString()
        {
            string str = "";
            foreach (Manga m in Mangas)
                str += m + "\n";
            return str;
        }

        public bool updateManga(Manga manga)
        {
            try
            {
                Mangas[
                    Mangas.FindIndex(
                        m => m.ID == manga.ID)].Copy(manga);
            }
            catch (Exception e)
            {
                Console.WriteLine("OUPS...");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;
        }
    }
}
