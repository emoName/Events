using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.experiment
{
    public delegate void DelegEvent(string s);
    static class NewPublisher
    {
        //  public event EventHandler<SomeDelegate> some;
        public static DelegEvent Event;
        public static event EventHandler<User> UserChanged;


        static public void OnUserChange(Object o, User u)
        {

            UserChanged?.Invoke(o, u);

        }


        static public void Subscriber(DelegEvent d)
        {
            Event += d;

        }
        static public void Unsubscribe(DelegEvent d)
        {
            Event -= d;
        }




    }
}
