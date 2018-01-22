using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Budgetis_V0.Models;
namespace Budgetis_V0.ViewModel
{
    public class CategorieTypeViewModel
    {
        public IEnumerable<TypeCategorie> TypesCategory { get; set; }

        public TypeCategorie TypeCat { get; set; }
        public Categorie categorie { get; set; }
    }
}