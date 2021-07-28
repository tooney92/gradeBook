using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            //var username = Console.ReadLine();
            Book book = new Book("Tony's book");

            while (true)
            {
                Console.WriteLine("Please provide a number(double): ");
                var userInput = Console.ReadLine();
                double userNumber = double.Parse(userInput);
                book.AddGrade(userNumber);


                Console.WriteLine("Are you done?");
                var answer = Console.ReadLine();

                if (answer.StartsWith("y"))
                {
                    break;
                }
            }

            book.ShowStatistics();

        }
    }
}