using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string[] names = new string[4];
            string[] names = { "Abhijeet", "Sirisha", "Varun", "Karthi","Raman" };
            //USING LINQ QUERIES
            //UsingLINQ(names);

            //USING LINQ EXTENSIONS(METHODS)
            //UsingLINQExtensions(names);

            //USING LINQEXTENSIONS
            //UsingLINQExtensions(names);

            //USING LINQANONYMOUS METHODS
            // UsingAnonymousMethods(names);

            //WOKRING WITH XML USING LINQ
            //LINQReadsXML();

            //XML ADD AND ADDFIRST
            //LINQADDXML();

            //XML REMOVE DATA
            LINQDELXML();
        }

        
        public static void UsingLINQ(string[] B)
        {
            IEnumerable<string> query = from s in B
                                        where s.Length == 5
                                        orderby s
                                        select s;
            foreach (string item in query)
                Console.WriteLine(item);

            Console.Read();
        }

        public static void UsingLINQExtensions(string[] name)
        {
            IEnumerable<string> query = name
                                        .Where(s => s.Length == 5)
                                        .OrderBy(s => s)
                                        .Select(s => s.ToUpper());

            foreach (var item in query)
                Console.WriteLine(item);

            Console.Read();
        }

        public static void UsingLINQFunctions(string[] name)
        {
            Func<string, bool> filter = s => s.Length == 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToUpper();

            IEnumerable<string> query = name
                                        .Where(filter)
                                        .OrderBy(extract)
                                        .Select(project);

            foreach(var B in query)
            {
                Console.WriteLine(B);
            }

            Console.Read();
        }

        public static void UsingAnonymousMethods(string[] name)
        {
            Func<string, bool> filter = delegate (string s)
             {
                 return s.Length == 5;
             };
            Func<string, string> extract = delegate (string s)
            {
                return s;
            };
            Func<string, string> project = delegate (string s)
            {
                return s.ToUpper();
            };

            IEnumerable<string> query = name
                                        .Where(filter)
                                        .OrderBy(extract)
                                        .Select(project);
            foreach (var item in query)
                Console.WriteLine(item);

            Console.Read();

        }

        public static void LINQReadsXML()
        {
            string MyXML = @"<Departments>
                             <Department>Account</Department>
                             <Department>Sales</Department>
                             <Department>Pre-Sales</Department>
                             <Department>Marketing</Department>
                             </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(MyXML);

            var result = xdoc.Elements("Departments").Descendants();
            foreach (XElement item in result)
                Console.WriteLine("The department name is : " + item.Value);

            Console.ReadKey();



        }

        public static void LINQADDXML()
        {
            string MyXML = @"<Departments>
                             <Department>Account</Department>
                             <Department>Sales</Department>
                             <Department>Pre-Sales</Department>
                             <Department>Marketing</Department>
                             </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(MyXML);
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));
            xdoc.Element("Departments").Add(new XElement("Department", "Support"));
            var result = xdoc.Elements("Departments").Descendants();
            foreach (XElement item in result)
                Console.WriteLine("The department name is : " + item.Value);

            Console.ReadKey();
        }

        public static void LINQDELXML()
        {
            string MyXML = @"<Departments>
                             <Department>Account</Department>
                             <Department>Sales</Department>
                             <Department>Pre-Sales</Department>
                             <Department>Marketing</Department>
                             </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(MyXML);
            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();
            var result = xdoc.Elements("Departments").Descendants();
            foreach (XElement item in result)
                Console.WriteLine("The department name is : " + item.Value);

            Console.ReadKey();
        }
    }
}
