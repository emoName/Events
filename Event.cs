using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class NewMailEvevent : EventArgs
    {
        public readonly string s;

        public NewMailEvevent(string s)
        {
            this.s = s;

        }





    }

    class MailManager
    {
        public event EventHandler<NewMailEvevent> newMail;


        public void OnNewMail(NewMailEvevent e)
        {
            if ( newMail != null )
            {
            newMail(this, e);

            }

        }


        public void SimulateMail(string s)
        {
            NewMailEvevent e = new NewMailEvevent(s);

            OnNewMail(e);

        }



    }


}
