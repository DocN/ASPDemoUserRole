using Assignment1.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class UserSpecs
    {
        public List<String> CurrentRole {get;set;}
        public List<IdentityRole> AvailableRoles { get; set; }
    }
}
