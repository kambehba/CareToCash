using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareToCash.Shared
{
    public class Test1
    {
        [JSInvokable]
        public static void dothis()
        {
            Console.WriteLine("dddqqqq11");
        }
    }
}
