using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoursScaffolding.Models;

namespace CoursScaffolding.Models
{
    public class Adresse
    {
        [Key]
        [Column(Order = 1)]
        public int Rue { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Ville { get; set; }
        [Key]
        [Column(Order = 3)]
        public string CodeP { get; set; }
        [ForeignKey("Personne")]
        public int PersonneId { get; set; }
        public Personne Personne { get; set; }

    }
}