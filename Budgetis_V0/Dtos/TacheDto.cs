using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budgetis_V0.Dtos
{
    public class TacheDto
    {
        public int id { get; set; }
        public String libelle { get; set; }
        public String description { get; set; }
        public double cout { get; set; }

        public DateTime dateEstimation { get; set; }

        public DateTime dateExecution { get; set; }
        public Boolean isFinished { get; set; }

        public int TypeCategorieID { get; set; }
        public TypeCategorieDto typeCategorie { get; set; }
    }
}