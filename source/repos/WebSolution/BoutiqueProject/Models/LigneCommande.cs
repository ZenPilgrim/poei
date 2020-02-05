using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoutiqueProject.Models
{
    public class LigneCommande
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Num { get; set; }
        public int Quantity { get; set; }
        public virtual Article Article { get; set; }
        public virtual Commande Commande { get; set; }
    }
}