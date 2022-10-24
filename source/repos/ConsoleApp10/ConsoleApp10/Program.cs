using System;

namespace ConsoleApp10
{   //Error handling
    //public class Math
    //{
    //    double result;
    //    public Math()
    //    {
    //        result = 0.0;
    //    }

    //    public void division(int a, int b)
    //    {
    //        try
    //        {
    //            result = b / a;
    //            result = a / b;
    //        }
    //        catch (DivideByZeroException e) //Exception is the parent of DivideByZeroException
    //        {
    //            Console.WriteLine("Exception caught " + e);
    //        }
    //        catch (Exception e) //Exception is the parent of DivideByZeroException
    //        {
    //            Console.WriteLine("Exception caught at " + e);
    //        }
    //        finally 
    //        {
    //            Console.WriteLine("the result is " + result);
    //        }

    //    }
    //}

    // CUSTOM EXCEPTIONS
    public class AmountIsZeroEx : Exception
    {
        public AmountIsZeroEx(string message) : base(message)
        {

        }
    }

    public class AmountValidator
    {
        int amount = 0;

        public void AmountCalc()
        {
            if (amount == 0)
                throw (new AmountIsZeroEx("Zero Amount Detected"));
            else
                Console.WriteLine("Amount is " + amount);
        }
    }
        
    class Program
    {   
        static void Main(string[] args)
        {
            // CUSTOM EXCEPTIONS
            AmountValidator amt = new AmountValidator();
            try
            {
                amt.AmountCalc();
            }
            catch(AmountIsZeroEx e)
            {
                Console.WriteLine("ZERO AMOUNT " + e);
            }
            

            // ERROR HANDLING

            //Math m1 = new Math();
            //m1.division(25, 0);

            
            //Console.WriteLine("Hello World!");
        }
    }
}
