using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.experiment
{
    class Subscriber1
    {

        public void Method1(string s)
        {
            Console.WriteLine($"This is : {this.GetType().Name}  Whith Call Message : {s}");

        }




    }
}
