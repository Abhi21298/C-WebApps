using System;
using System.Text;
using System.IO;
namespace ConsoleApp12
{
    //EXTENSION METHODS
    public static class ExtensionMethod
    {
        public static bool isEqualTo(this int a, int val)
        {
            return a == val;
        }
    }
    class Program
    {   
        
        static void Main(string[] args)
        {
            // EXTENSION METHODS
            //int i = 40;
            //Console.WriteLine(i.isEqualTo(45));


            // FILE OPERATIONS -- READ ROUNDABOUT AWAY

            //FileInfo f1 = new FileInfo(@"text.txt");

            //FileStream fs = f1.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //byte[] fileBytes = new byte[fs.Length];

            //int NumBytesToRead = (int)fileBytes.Length;

            //int NumBytesRead = 0;

            //while(NumBytesToRead > 0)
            //{
            //    int n = fs.Read(fileBytes, NumBytesRead, NumBytesToRead);

            //    if (n == 4)
            //        break;

            //    NumBytesToRead -= n;
            //    NumBytesRead += n;
            //}

            //string filestring = Encoding.UTF8.GetString(fileBytes);

            //Console.WriteLine(filestring);

            // FILE OPERATIONS -- READ SIMPLE WAY
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                FileInfo f2 = new FileInfo(@"text1.txt");

                fs = f2.Open(FileMode.Open, FileAccess.Read, FileShare.Read);

                sr = new StreamReader(fs);

                string fa = sr.ReadToEnd();

                Console.WriteLine(fa);
            }
            catch(Exception e)
            {
                Console.WriteLine("this is an exception " + e.Message);
            }
            finally
            {
                if(fs!=null && sr!=null)
                {
                    sr.Close();
                    fs.Close();
                }
             
            }
           
            //Console.WriteLine("Hello World!");
        }
    }
}
