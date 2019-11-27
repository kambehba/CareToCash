using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareToCash.Models
{
    public class Charge
    {
        public int Id { get; set; }
        public int ChargeValue { get; set; }
        public string Description { get; set; }
    }
}
