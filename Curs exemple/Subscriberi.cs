using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Fax
    {
        public Fax()
        {

        }

        public Fax(MailManager e)
        {
            e.newMail += FaxMsg;
          
        }

        public void FaxMsg(object sender, NewMailEvevent e)
        {
            Console.WriteLine("New Mesage Fax ");

            Console.WriteLine(e.s);



        }

        public void Unsubscribe(MailManager e)
        {
            e.newMail -= FaxMsg;
        }



    }

    class Phone
    {
        public Phone()
        {

        }

        public Phone(MailManager e)
        {
            e.newMail += PhoneMsg;

        }

        public void PhoneMsg(object sender, NewMailEvevent e)
        {
            Console.WriteLine("New Mesage Phone ");

            Console.WriteLine(e.s);



        }

        private void Unsubscribe(MailManager e)
        {
            e.newMail -= PhoneMsg;
        }


    }




}


