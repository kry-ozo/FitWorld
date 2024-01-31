using FitWord.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitWorld.Models.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Required]
        public  string NickName {  get; set; }
        public ICollection<Meal> Meals { get; set; }
        public ICollection<Plan> Plans { get; set; }
    }
}
