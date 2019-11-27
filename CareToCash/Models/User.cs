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

        public int Id { get; set; }
        public string Name { get; set; }
        public int Cash { get; set; }
        public List<Care> Cares { get; set; }
        public List<Charge> Charges { get; set; }

    }
}
