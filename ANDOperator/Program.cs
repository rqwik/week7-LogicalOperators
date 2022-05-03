using System;

namespace ANDOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND - && (проверка условий)
            //true && true => true  - userName && password => welcome!
            //true && false => false  - userName && password => acces denied
            //false && true => false  - userName && password => acces denied
            //false && false => false  - userName && password => acces denied

            //control data: userName = admin, password = "1234"
            string userName, password;
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Please, enter your username:");
                userName = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                password = Console.ReadLine();

                if (userName == "admin" && password == "1234")
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Acces denied. Wrong username and/or password. Try again. U have {3 - i} tries left.");
                }
            }
        }
    }
}
