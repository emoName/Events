using Events.experiment;
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
            //Delegate d = new Delegate();

            //d.RunMethod();

            //Console.WriteLine("===========================================================");
            ////-------------------------------------------------------------------------------------------------


            //MailManager mail = new MailManager();


            //Fax fax = new Fax(mail);
            //Phone phone = new Phone(mail);

            //mail.SimulateMail("Mesaj 1 din Main !! ");

            //fax.Unsubscribe(mail);
            //Console.WriteLine();

            //mail.SimulateMail("Mesaj 2 din Main !!!");

            //----------------------------------------------------------------------------------------------------


            NewPublisher publisher = new NewPublisher();

            Subscriber1 subscriber1 = new Subscriber1();
            Subscriber2 subscriber2 = new Subscriber2();


            WeakEvents.AddSubscriber(ref publisher.Event, subscriber1.Method1);
            WeakEvents.AddSubscriber(ref publisher.Event, subscriber2.Method1);
            publisher.Subscriber(
                (s) =>
                {
                    Console.WriteLine("Anonimus Method : Call message => " + s);
                });
            //  WeakEvents.UnSubscribe(ref publisher.Event, subscriber2.Method1);

            //  subscriber1.Method1("fwrefed");


            publisher.Unsubscribe((s) =>
            {
                Console.WriteLine("Anonimus Method : Call message => " + s);
            });

            publisher.Unsubscribe(subscriber1.Method1);

            publisher.SendMessage("Hello World !!!");









            Console.WriteLine();

            Console.ReadLine();
        }

        static public void Method1(string s)
        {
            Console.WriteLine($"Method 1 form Main : Call Message => {s}");
        }

    }
}
