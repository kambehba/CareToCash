using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareToCash.Models
{
    public class Care
    {
        public int userId { get; set; }
        public string care { get; set; }
        public int careValue { get; set; }
        public int status { get; set; }
    }
}
