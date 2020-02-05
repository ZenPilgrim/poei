using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAspNet.Models
{
    public class Personne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Num { get; set; }
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        public bool Sportif { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual List<Role> Roles { get; set; }


        public override string ToString()
        {
            return Prenom + " " + Nom;
        }

    }
}