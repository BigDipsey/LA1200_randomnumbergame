using System;

namespace IMS_Lernatelier_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int userguess;
            int timesuguessed;

            
            int randomnumber = new Random().Next(1, 100);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Welcome to the Number guessing Game");
            Console.WriteLine("Guess a anumber between 1 and 100:");
            timesuguessed = 0;
            userguess = 0;
            
         
            while (userguess != randomnumber)
            {
                timesuguessed++;
                try
                {
                    userguess = Convert.ToInt32(Console.ReadLine());


                    if (userguess >= 100 && userguess < 0)
                    {
                        Console.WriteLine("Invalid number, only try numbers between 1 - 100!");

                    }
                    else
                    {

                    }

                    if (userguess == randomnumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Yuhu you guessed the Number :D");
                        Console.WriteLine("You guessed " + timesuguessed + " times");

                    }
                    else if (userguess < randomnumber)
                    {
                        Console.WriteLine("You guessed to low :(");

                    }
                    else if (userguess > randomnumber)
                    {
                        Console.WriteLine("You guessed to high :(");
                    }

                }
                catch
                {
                    Console.WriteLine("Invalid sign, only try numbers between 1- 100!");

                }

                
            }
        }

    }
}
