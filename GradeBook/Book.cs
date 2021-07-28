using System;
using System.Collections.Generic;


namespace GradeBook
{
    public   class Book
    {
        public List<double> grades = new List<double>();
        public string Name;

        public Book(string name)
        {
            Name = name;
        }

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }

            else
            {
                throw new ArgumentException($"{grade} is an invalid grade. Grades between 0-100 are allowed.");
            }
            //Console.WriteLine($"grades added {grade}");
        }

        public Statistics GetStatistics()
        {
            // TODO: get the highest grade  
            // TODO: get the lowest grade
            // TODO: compute the average
            Statistics result = new Statistics();
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            result.Average = 0.0;

            foreach (var number in grades)
            {
                result.Low = Math.Min(number, result.Low);
                result.High = Math.Max(number, result.High);
                result.Average += number;
            }

            result.Average /= grades.Count ;
            return result;

        }
    }
}