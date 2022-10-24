using System;
using System.Linq;
namespace ConsoleApp8
{
    class Program
    {
        public void reverse()
        {
            string rev;
            Console.WriteLine("Enter the string to reverse");
            rev = Console.ReadLine();
            for(int i=0;i<rev.Length;i++)
            {
                Console.Write(rev[i]);
            }
            for (int i = rev.Length - 1; i >= 0; i--)
            {
                Console.Write(rev[i] + " ");
            }
        }

        public void reversenumber()
        {
            int[] numb = new int[10];
            Console.WriteLine("Enter the array to reverse");
            for (int i=0;i<10;i++)
            {
                numb[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=numb.Length-1;i>=0;i--)
            {
                Console.Write(numb[i] + " ");
            }
        }
        
        public void swap()
        {
            Console.WriteLine("Swapping");
            string ch1 = Console.ReadLine();
            string ch2 = Console.ReadLine();
            Console.WriteLine("First name is {0}", ch1);
            Console.WriteLine("Last name is {0}", ch2);
            string ch3 = ch1;
            ch1 = ch2;
            ch2 = ch3;
            Console.WriteLine("First name is {0}", ch1);
            Console.WriteLine("Last name is {0}", ch2);
        }
        
        public void PhoneSplit()
        {
            string phone = "+91876543218";
            //string[] splitre = phone.Split("+91");
            for(int i=0;i<3;i++)
            {
                Console.Write(phone[i]);
            }
            Console.Write(" ");
            for (int i = 3; i < phone.Length; i++)
            {
                Console.Write(phone[i]);
            }
            //Console.Write(" " + p);
        }

        public void Check()
        {
            int[] arr = new int[] { 23, 4, 65, 7, 8, 92 };
            int count = 0;
            foreach(var b in arr)
                if (b > 15)
                    count = count + 1;
            Console.WriteLine("the number of no.s greater than 15 are:" + count);
            
        }
        
        // ENUMS

        //enum days {Sun,Mon,Tue,Wed,Thur,Fri,Sat};

        static void counts()
        {
            string ch = "She sells sea Shells on the Sea Shore";
            string[] splits = ch.Split(" ");
            int countLetters=0,countWords = 0;
            foreach(var B in splits)
            {
                countLetters = countLetters + B.Length;
                countWords = countWords + 1;
            }
            Console.WriteLine("the number of words is " + countWords);
            Console.WriteLine("the number of letters is " + countLetters);
        }

        static void equality()
        {
            string ch1 = "She sells sea Shells on the Sea Shore";
            string ch2 = "She sells sea Shells on the Sea Shore";
            string ch3 = "Jett";
            if (ch1.ToLower().Equals(ch2.ToLower()))
                Console.WriteLine("THe strings are equal");
            else
                Console.WriteLine("THe strings arent equal");
            if (ch1.ToLower().Equals(ch3.ToLower()))
                Console.WriteLine("the strings are equal");
            else
                Console.WriteLine("The strings arent equal");
        }
        
        static void lastcheck()
        {
            Console.WriteLine("last letter check ");
            string ch = Console.ReadLine();
            bool yes = ch.EndsWith('a');
            Console.WriteLine(yes);
        }

        static void concat()
        {
            Console.WriteLine("Concatenate ");
            string ch1, ch2;
            ch1 = Console.ReadLine();
            ch2 = Console.ReadLine();
            string ch3 = ch1 + ch2;
            Console.WriteLine("The concatenated string is " + ch3);
        }

        static void repeatcounts()
        {
            Console.WriteLine("Count repeat occurrences of letters enter the string");
            string ch = Console.ReadLine();
            int counts = 0;
            ch = String.Join(" ", ch).ToLower();
            var arr = ch.ToCharArray().Distinct().ToArray();
            foreach (var b in arr)
            {
                foreach (var c in ch)
                    if (c == b)
                        counts++;
                Console.WriteLine("the occurrence of " + b + " is " + counts + " times");
                counts = 0;
            }
        }
        static void Main(string[] args)
        {
            //Program prog = new Program();
            //prog.reverse();
            //prog.reversenumber();
            //prog.swap();
            //prog.PhoneSplit();
            //prog.Check();

            // STRING FUNCTIONS _--------------------------

            //string fname, lname;
            //fname = "Abhi";
            //lname = "Jeet";

            //char[] letters = { 'W', 'o', 'r', 'l','d' };
            //string[] sarray = { "Hello", "From", "Mark", "John" };

            //string fullname = fname + lname;
            //Console.WriteLine("Fullname:" + fullname);

            //string Welcome = new string(letters);
            //Console.WriteLine("Greetings: {0} {1}", Welcome, "Hello");

            //string message = String.Join(" ", sarray);
            //Console.WriteLine("Message : {0}", message);

            //DateTime datetime = new DateTime(2020, 10, 11, 17, 55, 1);
            //string chat = String.Format("message sent at {0:t} on {0:D}", datetime);
            //Console.WriteLine("Message : {0}", chat);
            //Console.WriteLine("Hello World!");

            // ENUM ------------------------------------------------------
            //int Monday = (int)days.Mon;
            //int Friday = (int)days.Fri;

            //Console.WriteLine("Monday:{0}:", Monday);
            //Console.WriteLine("Friday:{0}", Friday);
            //Console.ReadKey();

            // EXERCISES - 2
            char[] ch = { 'M','a','d','a','m'};
            Console.WriteLine(ch.Reverse());
            //counts();
            //equality();
            //lastcheck();
            //concat();
            //repeatcounts();
        }
    }
}
