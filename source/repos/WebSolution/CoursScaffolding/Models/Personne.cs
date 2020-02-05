using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoursScaffolding.Models;

namespace CoursScaffolding.Models
{
    public class Personne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Adresse> Adresses { get; set; }
        public Personne()
        {
            Adresses = new List<Adresse>();
        }


    }
}