using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegate d = new Delegate();

            d.RunMethod();

            Console.WriteLine("===========================================================");
            //-------------------------------------------------------------------------------------------------


            MailManager mail = new MailManager();


            Fax fax = new Fax(mail);
            Phone phone = new Phone(mail);

            mail.SimulateMail("Mesaj din Main !! ");

           // fax.




            Console.ReadLine();
        }
    }
}
