using System;

namespace ConsoleApp5
{
    //class Program -- For public
    //class Program -- For private
    class Program : ProtectedSample //-- For protected
    //class Program -- For internal
    //class Program
    {
        static void Main(string[] args)
        {
            //PublicSample publicsample = new PublicSample();
            //Console.WriteLine(publicsample.name);
            //publicsample.Msg("Maddy");

            //PrivateSample privatesample = new PrivateSample();
            //Console.WriteLine(privatesample.name);
            //privatesample.Msg("Maddy");
            
            //ProtectedSample prot = new ProtectedSample();
            Program prot = new Program();
            Console.WriteLine(prot.name);
            prot.Msg("Maddy");

            //InternalSample internalsample = new InternalSample();
            //Console.WriteLine(internalsample.name);
            //internalsample.Msg("Maddy");
            //int a = 10;

            //while(a < 20)
            //{
            //    Console.WriteLine("The value of a is {0}", a);
            //    a++;
            //}


            //int a = 10;
            //do
            //{
            //    Console.WriteLine("The value of a is {0}", a);
            //    a++;
            //}
            //while (a < 20);
            int a = 10;
            do
            {
                if(a==15)
                {
                    a = a + 1;
                    //continue;
                    break;
                }
                Console.WriteLine("The value of a is {0}", a);
                a++;
            }
            while (a < 20);

            //// Console.WriteLine("Hello World!");
        }
    }
}
