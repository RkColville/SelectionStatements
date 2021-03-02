using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int favoriteNumber = 7;
            //var r = new Random();
            //var favNumber = r.Next(1, 1000);
            //Console.WriteLine("Guess my favorite number");
            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput < favoriteNumber)
            //{
            //    Console.WriteLine("too Low");
            //}
            //else if (userInput > favoriteNumber)
            //{
            //    Console.WriteLine("too high");
            //}
            //else if (userInput == favoriteNumber)
            //{
            //    Console.WriteLine("Congrats dude! You just won a used 2014 Toyota FJ");
            //}
            //else
            //{
            //    Console.WriteLine("Nevermind");

            string subject = "c#";

            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)

            {
                case "c#":
                    Console.WriteLine("You are in the right class!");
                    break;
                case "Java":
                    Console.WriteLine("C# is better than Java");
                    break;

                default:
                    Console.WriteLine("We teach coding here");
                    break;
            }
            
        }
    }
}
