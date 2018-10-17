using Assignment1.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Compound
    {
        public double Principal { get; set; }
        public double Rate { get; set; }
        public double Number { get; set; }
        public double Time { get; set; }

        public double Result { get; set; }

    }
}
