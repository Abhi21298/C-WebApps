using System;

namespace ConsoleApp6
{
    public class TestData
    {
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }

        public int Add(int a,int b)
        {
             return a + b;
       }
    }
    //public class Account
    // {
    //    //private static double balance;
    //    private double balance;
    //    //public static double GetBalance()
    //    public double GetBalance()
    //    {
    //        return balance;
    //    }
    // }


   // public class Animal
    class Animal
    {
        //public void get() { Console.WriteLine("The Animal is.."); }
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal Talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal Song");
        }
    }

    class Dog : Animal
    {
        // public void bark() { Console.Write("a dog barking"); }
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }

        public new void Talk()
        {
            Console.WriteLine("Dog talks");
        }

        public override void Sing()
        {
            Console.WriteLine("Dog Sings");
        }
    }
    public class Pug
    {
        public void puggy() { Console.WriteLine("and it is a pug"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[10];
            //int sum=0;
            //double average;
            //for(int i=0;i<10;i++)
            //{
            //    a[i]= Convert.ToInt32(Console.ReadLine());
            //    sum = sum + a[i];
            //}
            //average = Convert.ToDouble(sum / 10);
            //Console.WriteLine("Sum = {0}, Average = {1}",sum,average);
            //Console.WriteLine("Hello World!");
            //int i = 1, j = 1;
            //while (i <= 4)
            //{
            //    while (j <= i)
            //    {
            //        Console.Write(j);
            //        j++;
            //    }
            //    Console.WriteLine();
            //    j = 1;
            //    i++;

            //}

            //long a = 97658673542;
            //int q = new int();
            //Console.WriteLine("The last digit of this number is {0}", a % 10);
            //while (a % 10 !=0) { q = Convert.ToInt32(a % 10);  a = a / 10; }
            //Console.WriteLine("The first digit is {0}", q);

            //Pug pug = new Pug();
            //pug.get();
            //pug.bark();
            //pug.puggy();
            //Animal ani = new Animal();
            //ani.Greet();
            //ani.Talk();
            //ani.Sing();
            Dog dog = new Dog();
            dog.Greet();
            dog.Talk();
            dog.Sing();

            //Account obj = new Account();
            //double currentbalance = Account.GetBalance();//obj.GetBalance(); Account.GetBalance();

            //obj.balance = 20;
            //TestData dataClass = new TestData();
            //int add2 = dataClass.Add(45, 33, 21);
            //int add1 = dataClass.Add(20, 40);
            //Console.WriteLine(add1);
            //Console.WriteLine(add2);
        }
       
    }

}
