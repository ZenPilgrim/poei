using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;


namespace BoutiqueProject.Models
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Num { get; set; }
        public float PrixUnitaire { get; set; }
        public string Designation { get; set; }
        public int QuantiteStock { get; set; }
        public string Image { get; set; }
        public virtual ICollection<LigneCommande> LigneCommande { get; set; }
    }
}