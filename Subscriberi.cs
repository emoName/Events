using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Fax
    {

        public Fax(MailManager e)
        {
            e.newMail += FaxMsg;
          
        }

        private void FaxMsg(object sender, NewMailEvevent e)
        {
            Console.WriteLine("New Mesage Fax ");

            Console.WriteLine(e.s);



        }

        private void Unsubscribe(MailManager e)
        {
            e.newMail -= FaxMsg;
        }



    }

    class Phone
    {

        public Phone(MailManager e)
        {
            e.newMail += PhoneMsg;

        }

        private void PhoneMsg(object sender, NewMailEvevent e)
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


