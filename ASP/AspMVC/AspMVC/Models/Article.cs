using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspMVC.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Theme { get; set; }

        [Required(ErrorMessage = "Author Requis")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Created { get; set; }
        public string Image { get; set; }

        [StringLength(200, ErrorMessage = "Longueur Max=200")]
        [Required(ErrorMessage = "Contenu Requis")]
        [ValidatorCar(ErrorMessage = "erreur format")]
        public string Content { get; set; }
        public virtual ICollection<Commentaire> Comments { get; set; } = new List<Commentaire>();

    }
}