using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleApp.Models
{
    public class Message
    {
        [Display(Name = "Emetteur :")]
        public string Emetteur { get; set; }
        [Display(Name = "Contenu :")]
        public string Contenu { get; set; }
        [Display(Name = "Date :")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Emetteur: {Emetteur}, Contenu: {Contenu}, Date: {Date.ToShortDateString()}";
        }
    }
}