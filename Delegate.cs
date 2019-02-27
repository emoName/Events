using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{


    delegate void MyDelegate(string s);


    class Delegate
    {
        // necesita declarata la nivel de clasa nu metoda
        event MyDelegate myDelegate;//= new MyDelegate(Method1);
        public void RunMethod()
        {
            string s;



            myDelegate += Method2;
            myDelegate += Method3;
            myDelegate += Method4;

            myDelegate("");
            Console.WriteLine();

            myDelegate -= Method1;
            // IF NOT NULL
            myDelegate?.Invoke("");



        }

        void Method1(string s)
        {
            Console.WriteLine(" Method1 ");
        }
        void Method2(string s)
        {
            Console.WriteLine(" Method2 ");
        }
        void Method3(string s)
        {
            Console.WriteLine(" Method3 ");
        }
        void Method4(string s)
        {
            Console.WriteLine(" Method4 ");
        }

    }
}
