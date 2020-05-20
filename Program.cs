using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            Console.WriteLine("Welcome to Panda-Karady\'s Stop Watch");
            Console.WriteLine("Press 1 - Start, 2 - Stop, 0 - Exit");
            while (true)
            {
                var userInput = Console.ReadLine();
                var isNumber = int.TryParse(userInput, out var value);
                if (isNumber)
                {
                    if (value == 1)
                    {
                        stopWatch.Start();
                    } else if (value == 2)
                    {
                        stopWatch.Stop();
                    }
                    else if(value == 0)
                    {
                        Console.WriteLine("**********************");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not valid input. Try again...");
                    }
                } else
                {
                    Console.WriteLine("Not valid input. Try again...");
                }
            }
        }
    }
}