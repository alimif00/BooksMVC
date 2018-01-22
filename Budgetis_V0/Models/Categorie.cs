using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Budgetis_V0.Models
{
    public class Categorie
    {

        public int Id { get; set; }
        [Required]
        public string Libelle { get; set; }
        public string Description { get; set; }
    }
}