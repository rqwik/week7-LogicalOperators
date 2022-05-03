using System;

namespace EnglishWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            // t < 0 then Freezing Cold
            //0 - 10 then Very Cold
            //10 - 20 then Cold
            //20 - 30 then Warm
            //30 - 35 then Hot
            //>+= 35 then Boiling Hot

            int currentTemp;
            Console.WriteLine("Please, enter the temperature:");
            currentTemp = Convert.ToInt32(Console.ReadLine());

            if(currentTemp < 0)
            {
                Console.WriteLine("Freezing Cold");
            }
            else if(currentTemp >= 0 && currentTemp <= 10)
            {
                Console.WriteLine("Very Cold");
            }
            else if(currentTemp > 10 && currentTemp <= 20)
            {
                Console.WriteLine("Cold");
            }
            else if(currentTemp > 20 && currentTemp <= 30)
            {
                Console.WriteLine("Warm");
            }
            else if(currentTemp > 30 && currentTemp <= 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("Boiling Hot");
            }
        }
    }
}
