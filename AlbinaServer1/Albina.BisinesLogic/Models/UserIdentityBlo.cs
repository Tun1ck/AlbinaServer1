using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BisinesLogic.Models
{
    public class UserIdentityBlo
    {
        public int Id { get; set; }
        public string NumberPrefix { get; set; }

        public string Number { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; } 
        public string ImageUrl { get; set; }
    }
}
