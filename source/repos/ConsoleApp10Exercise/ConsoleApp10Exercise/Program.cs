using System;

namespace ConsoleApp10Exercise
{
    class Program
    {
        public class OfferExpired : Exception
        {
            public OfferExpired(string message) : base(message)
            {
                
            }
        }

        public class OfferCheck
        {
            DateTime dt = new DateTime(2021, 02, 09, 16, 09, 01);
            
            public void check()
            {
                if(DateTime.Now > dt)
                {
                    throw (new OfferExpired("Sorry offer is over"));
                }
                else
                {
                    Console.WriteLine("The offer still exists for " + (dt - DateTime.Now));
                }
            }
        }
        static void Main(string[] args)
        {
            OfferCheck a1 = new OfferCheck();
            try
            {
                a1.check();
            }
            catch (OfferExpired e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
