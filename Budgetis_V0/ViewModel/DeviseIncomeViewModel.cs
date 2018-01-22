using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Budgetis_V0.Models;

namespace Budgetis_V0.ViewModel
{
    public class DeviseIncomeViewModel
    {
        public IEnumerable<Devise> Devises { get; set; }
        public Income income { get; set; }
        public Devise DeviseSelected { get; set; }
    }
}