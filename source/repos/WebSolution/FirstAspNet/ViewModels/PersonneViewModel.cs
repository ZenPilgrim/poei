using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstAspNet.Models;

namespace FirstAspNet.ViewModels
{
    public class PersonneViewModel
    {
        public Personne Personne { get; set; }
        public List<int> Liste { get; set; }
        public int Id { get; set; }

    }
}