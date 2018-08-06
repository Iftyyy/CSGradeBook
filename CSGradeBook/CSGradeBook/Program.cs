﻿using System;
using System.IO;
using System.Linq.Expressions;

namespace CSGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook book = new Gradebook();
            GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);
        }

        private static void WriteResults(Gradebook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);
        }
        private static void SaveGrades(Gradebook book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))

            {
                book.WriteGrades(outputFile);
            }
        }
        private static void AddGrades(Gradebook book)
        {
            book.AddGrade(96);
            book.AddGrade(26.4f);
            book.AddGrade(95);
        }
        private static void GetBookName(Gradebook book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// static methods that display text regarding the gradebook and results
        /// </summary>
        /// 
        //private static void OnNameChanged(object sender, NamedChangedEventArgs args)
        //{
        //    Console.WriteLine($"Gradebook changing name from {args.ExistingName} to {args.NewName}");
        //}

        //private static void WriteResult(string description, int result)
        //{
        //    // string interpolation
        //    Console.WriteLine($"{description}: {result:F2}");
        //}
        private static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
        private static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }
    }
}
