using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareToCash.Models
{
    public class Charge
    {
        public int userId { get; set; }
        public string charge { get; set; }
        public int ChargeValue { get; set; }
    }
}
