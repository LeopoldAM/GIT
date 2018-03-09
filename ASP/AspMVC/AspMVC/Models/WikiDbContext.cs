using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AspMVC.Models
{
    public class WikiDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Commentaire> Comments { get; set; }
    }
}