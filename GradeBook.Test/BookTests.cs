using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        [Fact]
        public void GetsHighestScore()
        {
            Book book1 = new Book("tony's book");
            book1.AddGrade(21.34);
            book1.AddGrade(45.6);
            book1.AddGrade(85.6);

            var result = book1.GetStatistics();

            Assert.Equal(85.6, result.High);


        }
    }
}
