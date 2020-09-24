using System;

namespace ThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            Console.WriteLine("Wha is my numbr?");
            int userInput = Int32.Parse(Console.ReadLine());

            int counter = 0;
            
            while(counter < 3)
            {
                if(randomNumber == userInput)
                {
                    Console.WriteLine("Cangratulations, you won");
                    break;

                }
                else
                {
                    Console.WriteLine("Try again!");
                    Console.WriteLine("Wha is my numbr?");
                    userInput = Int32.Parse(Console.ReadLine());


                }
                counter++;
                Console.WriteLine($"you have guessed {counter} times.");

            }
        }
    }
}
