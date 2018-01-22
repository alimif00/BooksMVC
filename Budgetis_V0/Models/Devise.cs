using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budgetis_V0.Models
{
    public class Devise
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public bool IsSelected { get; set; }
    }
}