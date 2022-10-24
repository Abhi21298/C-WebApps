using System;

namespace ConsoleApp1Exercise
{   
    public static class Extension
    {
        //public int count;
        public static bool IsGreaterThan(this int a,int val)
        {
            return a > val;
        }

        public static int CountBs(this string b)
        {
            b = b.ToLower();
            int count = 0;
            char[] e = b.ToCharArray();
            foreach (var f in e)
                if (f == 'b')
                    count++;
            return count;
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            int i = 40;
            Console.WriteLine(i.IsGreaterThan(4));

            string b = "Backbone";
            Console.WriteLine(b.CountBs());
            //Console.WriteLine("Hello World!");
        }
    }
}
