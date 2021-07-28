using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Book
    {
        private List<double> grades = new List<double>();
        private string name;

        public Book(string name)
        {
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            //Console.WriteLine($"grades added {grade}");
        }

        public void ShowStatistics()
        {
            // TODO: get the highest grade
            // TODO: get the lowest grade
            // TODO: compute the average
            double lowestValue = double.MaxValue;
            double highestValue = double.MinValue;
            double sum = 0.0;

            foreach (var number in grades)
            {
                lowestValue = Math.Min(number, lowestValue);
                highestValue = Math.Max(number, highestValue);
                sum += number;

            }

            Console.WriteLine($"min value: {lowestValue}, max value: {highestValue} average: {sum / 5:N1}");

        }
    }
}