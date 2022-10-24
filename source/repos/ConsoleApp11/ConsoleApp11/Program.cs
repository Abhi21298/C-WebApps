using System;
using System.Collections;
namespace ConsoleApp11
{   
    // ABSTRACT CLASSES

    // abstract class Abstract
    //{
    //    public int TwoNumbers(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public abstract int MulTwoNumbers(int a, int b);
    //}

    //class Derived : Abstract
    //{

    //    public override int MulTwoNumbers(int a, int b)
    //    {
    //        return a * b;
    //    }
    //}

    // OPERATOR OVERLOADING

    //class Calci
    //{
    //    public int num = 0;

    //    public Calci()
    //    {

    //    }

    //    public Calci(int a)
    //    {
    //        num = a;
    //    }

    //    public static Calci operator +(Calci c1,Calci c2)
    //    {
    //        Calci c3 = new Calci(0);
    //        c3.num = c1.num + c2.num;
    //        return c3;
    //    }
    //}


    


    class Program
    {       
        //   <T> USAGE IN FUNCTIONS
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            // ABSTRACT CLASSES 

            //Derived d = new Derived();
            //Console.WriteLine(d.TwoNumbers(5, 10));
            //Console.WriteLine(d.MulTwoNumbers(5, 10));

            // OPERATOR OVERLOADING

            //Calci c1 = new Calci(20);
            //Calci c2 = new Calci(40);
            //Calci c3 = c1 + c2;
            //Console.WriteLine(c3.num);

            //HASHTABLE

            //Hashtable ht = new Hashtable();
            //ht.Add("001", "Jeet");
            //ht.Add("002", "shek");
            //ht.Add("003", 2);

            //if (ht.ContainsValue(2))
            //{
            //    Console.WriteLine("already present in hashtable");
            //}
            //else
            //    ht.Add("004", 2);
            ////Console.WriteLine("Hello World!");
            //ht.Remove("003");
            //ICollection a = ht.Keys;
            //var k = ht.Keys;
            //foreach (var K in k)
            //    Console.WriteLine("Key " + K + " Value " + ht[K]);

            // SORTED LIST

            //SortedList ht = new SortedList();
            //ht.Add(001, "Jeet");
            //ht.Add(002, "shek");
            //ht.Add(003, 44);
            //ht.Add(004, "kjashdkjah");
            //ht.Remove(003);

            //if (ht.ContainsValue(2))
            //{
            //    Console.WriteLine("already present in hashtable");
            //}
            //else
            //    ht.Add(005, 2);
            ////Console.WriteLine("Hello World!");

            //ICollection a = ht.Keys;
            //var k = ht.Keys;
            //foreach (var K in a)
            //    Console.WriteLine("Key " + K + " Value " + ht[K]);

            // <T> USAGE IN FUNCTIONS

            int c, d;
            char e, f;
            c = 10;
            d = 20;
            e = 'a';
            f = 'B';

            Console.WriteLine("integers before swapping " + c + " " + d);
            Console.WriteLine("Characters before swapping " + e + " " + f);

            Swap<int>(ref c, ref d);
            Swap<char>(ref e, ref f);

            Console.WriteLine("After swapping integers" + c + " " + d);
            Console.WriteLine("After swapping characters" + e + " " + f);

        }
    }
}
