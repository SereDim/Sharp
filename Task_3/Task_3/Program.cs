using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            double b = 0;
            decimal c = 0;
            bool t = true;
            
            
            
            
            
            do
            {
                t = true;
                try
                {
                    Console.WriteLine("Int:");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    t = false;
                    Console.WriteLine("Incorrect format");
                }
            }
            while (t == false);





            do
            {
                t = true;
                try
                {
                    Console.WriteLine("Doulbe:");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    t = false;
                    Console.WriteLine("Incorrect format");
                }
            }
            while (t == false);






            do
            {
                t = true;
                try
                {
                    Console.WriteLine("Long:");
                    c = Convert.ToDecimal(Console.ReadLine());
                }
                catch (FormatException)
                {
                    t = false;
                    Console.WriteLine("Incorrect format");
                }
            }
            while (t == false);



            Console.WriteLine("a = {0} b = {1}, c = {2}", a, b, c);
        }
    }
}
