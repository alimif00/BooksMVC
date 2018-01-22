using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Budgetis_V0.Models
{
    public class Tache
    {
        public int id { get; set; }
        [Display(Name = "Libellé")]
        public String libelle { get; set; }
        public String description { get; set; }
        public double cout { get; set; }
        [Display(Name="Date estimée")]
        public DateTime? dateEstimation { get; set; }
        [Display(Name = "Date d'éxécution")]
        public DateTime? dateExecution { get; set; }
        public Boolean isFinished { get; set; }
        [Display(Name = "Type")]
        public int TypeCategorieID { get; set; }
        public TypeCategorie typeCategorie { get; set; }



    }
}