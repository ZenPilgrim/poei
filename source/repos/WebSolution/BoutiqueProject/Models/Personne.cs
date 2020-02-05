using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoutiqueProject.Models
{
    public class Personne
    {
        public Personne()
        {
            new List<Role>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Num { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual List<Role> Roles { get; set; }


        public override string ToString()
        {
            return UserName + ", Num : " + Num;
        }

    }
}