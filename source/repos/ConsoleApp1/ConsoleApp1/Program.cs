using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] evenNums = new int[] { 2, 6, 3, 4, 5 };
            string[] cities = { "Chennai", "Mumbai", "Delhi", "Kolkata", "Blore" };
            foreach (var item in cities)
                Console.WriteLine(item);
            //Console.WriteLine(cities[2][1]);

            for (int i = 0; i < evenNums.Length; i++)
                if (evenNums[i] % 2 == 0)
                    //Console.WriteLine($"{evenNums[i]} is even");
                    Console.WriteLine(string.Format("{0} is even",evenNums[i]));
                    //Console.WriteLine(evenNums[i] + "is even");
                else
                    Console.WriteLine($"{evenNums[i]} is odd");

            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add(true);
            arlist1.Add(" ");
            arlist1.Add(null);
            arlist1.Add(4.5);
            
            arlist1.Insert(2, "abhi");
            for (int i = 0; i < arlist1.Count; i++)
                Console.Write(arlist1[i]+",");
            Console.Write("\n");
            ArrayList arlist2 = new ArrayList() { 200, 300 };
            arlist1.InsertRange(2, arlist2);
            foreach (var A in arlist1)
                Console.Write(A + ",");
            Console.Write("\n");
            arlist1.Add(4.6f);
            arlist1.Remove(null);
            arlist1.RemoveAt(4);
            arlist1.RemoveRange(0, 1);
            foreach (var A in arlist1)
                Console.Write(A + ",");
            Console.Write("\n");
            var citi = new List<string>() //List citi = new List<string>();
            {
                "Ranchi",
                "Pune",
                "Madurai"
            };
            citi.Add("Delhi");
            citi.AddRange(cities);
            citi.Insert(1, "Agra");

            citi.Remove("Chennai");
            citi.RemoveAt(5); foreach (var A in citi)
                Console.Write(A + ",");
            Console.Write("\n");
            var numbers = new List<int>()
            {
                10,20,30,40,50
            };
            //var a = Console.ReadLine();
            //int k = 0;
            //foreach(var B in numbers)
            //    if (Convert.ToInt32(a) == B)
            //    {
            //        k = 1;
            //        Console.Write("The number exists");
            //    }
               
            //if (k == 0)
            //    Console.Write("The number doesn't exist");
            Stack<int> stk = new Stack<int>();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Push(7);
            
            Console.Write(stk.Peek());
            while (stk.Count > 0)
                Console.Write(stk.Pop() + ",");
            Queue<int> Que = new Queue<int>();
            Que.Enqueue(1);
            Que.Enqueue(3);
            Que.Enqueue(5);
            Console.WriteLine();
            foreach (var B in Que)
                Console.WriteLine(B + ",");
            Console.WriteLine(Que.Peek());
            while (Que.Count > 0)
                Console.WriteLine(Que.Dequeue() + ",");
            
            
        }
    }
}
