using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BoutiqueProject.Models
{
    public class Commande
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Num { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateCommande { get; set; }
        public virtual ICollection<LigneCommande> LigneCommande { get; set; }
    }
}