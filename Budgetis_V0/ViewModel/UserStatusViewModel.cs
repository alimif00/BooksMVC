using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Budgetis_V0.Models;

namespace Budgetis_V0.ViewModel
{
    public class UserStatusViewModel
    {
        public UserTest userM { get; set; }
        public IEnumerable<SocialStatusType> socialStatusTypes { get; set; }

    }
}