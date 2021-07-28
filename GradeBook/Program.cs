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
                Console.WriteLine("Enter a grade or 'q' to quit");
                String userInput = Console.ReadLine();

                if (userInput.StartsWith('q'))
                {
                    Console.WriteLine(".... bye");
                    break;
                }

                //bool validInput = double.TryParse(userInput, out double result);
                //if(!validInput)
                //{
                //    Console.WriteLine("valid doubles only!");
                //    break;
                //}
                try
                {
                    var grade = double.Parse(userInput);
                    book.AddGrade(grade);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (FormatException e)
                {
                    Console.WriteLine("invalid format. Please use doubles");
                }

                finally
                {
                    Console.WriteLine("**");
                }

                //book.AddGrade(double.Parse(userInput));

            }

            var stats = book.GetStatistics();
            stats.printStats();

        }
    }
}