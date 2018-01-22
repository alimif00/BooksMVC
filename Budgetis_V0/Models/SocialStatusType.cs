using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Budgetis_V0.Models
{
    public class SocialStatusType
    {

        public int Id { get; set; }
        [Required]
        public string  libelle { get; set; }
        public string  description { get; set; }
        [Range(1,100)]
        public double tax { get; set; }

    }
}