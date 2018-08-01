using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook book = new Gradebook();

            book.NameChanged += OnNameChanged;

            book.Name = "Iftys Grade Book";
            book.Name = "Grade Book";

            book.AddGrade(96);
            book.AddGrade(26.4f);
            book.AddGrade(95);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
        }
        /// <summary>
        /// static methods that display text regarding the gradebook and results
        /// </summary>
        private static void OnNameChanged(object sender, NamedChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook changing name from {args.ExistingName} to {args.NewName}");
        }
        private static void WriteResult(string description, int result)
        {
            // string interpolation
            Console.WriteLine($"{description}: {result:F2}");
        }
        private static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}
