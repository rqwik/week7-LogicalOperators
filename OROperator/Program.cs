using System;

namespace ANDOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //OR - || - или      !=    - не равен
            //true || true => true
            //true || false => true
            //false || true => true
            //false || false => false

            //control data: userName = admin, password = "1234"
            string userName, password;
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Please, enter your username:");
                userName = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                password = Console.ReadLine();

                if (userName != "admin" || password != "1234")
                {
                    i++;
                    Console.WriteLine($"Acces denied. Wrong username and/or password. Try again. U have {3 - i} tries left.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
            }
        }
    }
}
