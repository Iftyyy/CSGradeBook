using System;
using CSGradeBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.UnitTest
{
    [TestClass]
    public class LetterGradeTest
    {
        [TestMethod]
        public void GradedCorrectGrade()
        {
            var book = new Gradebook();
            book.AddGrade(45);
            book.AddGrade(67);

            var result = book.ComputeStatistics();

            Assert.AreEqual("F", result.LetterGrade);
        }

        [TestMethod]
        public void CorrectGradeDescription()
        {
            var book = new Gradebook();
            book.AddGrade(100);
            book.AddGrade(100);

            var result = book.ComputeStatistics();

            Assert.AreEqual("Excellent", result.Description);
        }
    }
}
