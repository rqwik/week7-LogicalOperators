using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your purchase summa (integer):");
            int discount = Convert.ToInt32(Console.ReadLine());

            if(discount >= 0 && discount < 10)
            {
                Console.WriteLine("Sorry, but we don't have a discount for u.");
            }
            else if(discount >= 10 && discount < 20)
            {
                Console.WriteLine("Your discount on your next purchase will be 1 EUR.");
            }
            else if(discount >= 20 && discount <50)
            {
                Console.WriteLine("Your discount on your next purchase will be 5 EUR.");
            }
            else if (discount >= 50 && discount < 100)
            {
                Console.WriteLine("Your discount on your next purchase will be 10 EUR.");
            }
            else
            {
                Console.WriteLine("Your discount on your next purchase will be 15 EUR.");
            }

            Console.WriteLine("Have a good day!");
        }
    }
}
