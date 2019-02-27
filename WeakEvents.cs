using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class WeakEvents
    {

        public void Eventss()
        {
            MailManager mm = new MailManager();

            Fax fax = new Fax();
            Phone phone = new Phone();


            WeakEventManager<MailManager, NewMailEvevent>.AddHendler(mm,"ifrgbcikds",fax.FaxMsg);


        }







    }
}
