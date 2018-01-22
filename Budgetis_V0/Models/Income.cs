using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Budgetis_V0.Models
{
    public class Income
    {
        public int ID { get; set; }
        [Display(Name = "Montant")]
        public double IncomeValue { get; set; }
        [Display(Name = "Devise")]
        public int DeviseID { get; set; }

        public Devise Devise { get; set; }
    }
}