using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double avg = 250.0;
            double total = 250.0 *3;
            
            //candies to buy for clear and 50's
            double candiesinclear50 = 0.1*total+total;
            Console.WriteLine("numberof candies:{0}",candiesinclear50);

            double candiesinfullmoon40 = 0.5*total+total;
            Console.WriteLine("numberof candies:{0}", candiesinfullmoon40);
            
            double candiesinrainy70 = total-0.5*total;

            Console.WriteLine("numberof candies:{0}",candiesinrainy70);
            
        }
    }
}
