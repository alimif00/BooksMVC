using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budgetis_V0.Dtos
{
    public class TypeCategorieDto
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int CategorieID { get; set; }
        public CategorieDto Categorie { get; set; }
    }
}