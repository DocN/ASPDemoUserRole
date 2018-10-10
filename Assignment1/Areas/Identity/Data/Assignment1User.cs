using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Assignment1.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Assignment1User class
    public class Assignment1User : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public string AddressStreet { get; set; }
        [PersonalData]
        public string AddressCity { get; set; }
        [PersonalData]
        public string AddressProvince { get; set; }
        [PersonalData]
        public string AddressCountry { get; set; }
        [PersonalData]
        public String Role { get; set; }
    }
}
