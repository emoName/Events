using Events.experiment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
  static  class WeakEvents
    {

        public static void AddSubscriber(ref DelegEvent source , DelegEvent _event)
        {
            source += _event;
     
        }

        public static void UnSubscribe(ref DelegEvent source , DelegEvent _event)
        {
            source -= _event;
          
        }






    }
}
