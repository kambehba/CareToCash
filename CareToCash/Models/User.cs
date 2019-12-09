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
          //  cares = new List<Care>();
            //charges = new List<string>();

        }

        public int id { get; set; }
        public string name { get; set; }
        public int cash { get; set; }

        
        // public List<Care> cares { get; set; }
        //   public List<string> charges { get; set; }

    }
}
