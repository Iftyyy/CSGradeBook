using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSGradeBook;

namespace Grades.UnitTest
{
    [TestClass]
    public class GradebookTest
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(62);
            book.AddGrade(39);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(62, result.HighestGrade);

        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(62);
            book.AddGrade(39);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(39, result.LowestGrade);

        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(96);
            book.AddGrade(26.4f);
            book.AddGrade(95);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(72.46667, result.AverageGrade, 0.01);

        }
    }
}
