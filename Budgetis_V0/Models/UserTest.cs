using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Budgetis_V0.Models
{
    public class UserTest
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Prénom")]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Nom")]
        public string  LastName { get; set; }
        [Display(Name = "Date de naissance")]
        public DateTime DateNaissance { get; set; }
        public bool IsMember { get; set; }

        public SocialStatusType socialStatusType { get; set; }
        [Display(Name = "Statut social")]
        public int SocialStatusTypeId { get; set; }
    }
}