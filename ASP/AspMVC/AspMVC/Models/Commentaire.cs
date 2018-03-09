using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspMVC.Models
{
    public class Commentaire
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Author Requis")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [StringLength(200, ErrorMessage = "Longueur Max=200")]
        [Required(ErrorMessage = "Contenu Requis")]
        [ValidatorCar(ErrorMessage = "erreur format")]
        public string Content { get; set; }
        public Article Article { get; set; }
        public int ArticleId { get; set; }
    }
}