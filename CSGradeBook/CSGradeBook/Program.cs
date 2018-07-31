using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook book = new Gradebook();
            book.AddGrade(96);
            book.AddGrade(26.4f);
            book.AddGrade(95);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("The Average Grade is: " + stats.AverageGrade);
            Console.WriteLine("The Highest Grade is: " + stats.HighestGrade);
            Console.WriteLine("The Lowest Grade is: " + stats.LowestGrade);
        }
    }
}
