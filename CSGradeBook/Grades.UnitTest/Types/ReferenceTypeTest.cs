using System;
using System.Security.Policy;
using CSGradeBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.UnitTest.Types
{
    [TestClass]
    public class TypeTest
    {
        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        [TestMethod]
        public void UpperCaseToString()
        {
            string name = "ifty";
            name = name.ToUpper();
            Assert.AreEqual("IFTY", name);
        }
        
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2018, 12, 1);
            date.AddDays(1);
            Assert.AreEqual(1, date.Day);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 39;
            IncrementNumber(x);
            Assert.AreEqual(39, x);
        }

        private void GiveBookAName(Gradebook book)
        {
            book.Name = "A Gradebook";
        }
        [TestMethod]
        public void ReferenceTypePassByValue()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A Gradebook", book1.Name);

        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Ifty";
            string name2 = "ifty";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariableHoldValue()
        {
            int x1 = 100;
            int x2 = 64;

            x1 = 4; 
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void VariablesThatHoldReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;

            g1 = new Gradebook();
            g1.Name = "iftys Grade Book";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
