using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Budgetis_V0.Models;

namespace Budgetis_V0.ViewModel
{
    public class TacheCategorieTypeViewModel
    {
        public IEnumerable<Categorie> Categories { get; set; }

        public IEnumerable<TypeCategorie> TypeCategories { get; set; }

        public Tache tache { get; set; }
    }
}