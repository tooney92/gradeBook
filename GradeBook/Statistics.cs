using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Statistics
    {
        public double High;
        public double Low;
        public double Average;
        public char Letter;


        public void printStats()
        {

            switch (Average)
            {
                case var d when d >= 90.0:
                    Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    Letter = 'D';
                    break;

                default:
                    Letter = 'F';
                    break;
            }
            Console.WriteLine($"highest grade:{High} Lowest grade: {Low}, Average grade: {Average:N2} letter grade: {Letter}");
        }


    }
}
