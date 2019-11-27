using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareToCash.Models
{
    public class User
    {
        public User()
        {
          //  Care = new List<Care>();
        //    Charges = new List<Charge>();

        }

        public int id { get; set; }
        public string name { get; set; }
        public int cash { get; set; }
        //public List<Care> Cares { get; set; }
        //public List<Charge> Charges { get; set; }

    }
}
