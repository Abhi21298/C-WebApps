using System;

namespace ConsoleApp5
{
    //public class PublicSample -- For public
    //public class PrivateSample -- For private
    public class ProtectedSample// -- For protected
   // class InternalSample // -- For internal
    {
        //public string name = "Jeet";

        //public void Msg(string msg)
        //{
        //    Console.WriteLine("Hello " + msg);
        //}

        //private string name = "Jeet";

        //private void Msg(string msg)
        //{
        //    Console.WriteLine("Hello " + msg);
        //}

       protected string name = "Jeet";

        protected void Msg(string msg)
        {
          Console.WriteLine("Hello " + msg);
        }
       //internal string name = "Jeet";

        //internal void Msg(string msg)
        //{
        //    Console.WriteLine("Hello " + msg);
        //}
    }
}
