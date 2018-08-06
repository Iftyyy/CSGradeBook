using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGradeBook
{
    public class Gradebook : GradeTracker
    {
        public override IEnumerator GetEnumerator()
        {
            return _grades.GetEnumerator();
        }

        protected readonly List<float> _grades;
        public Gradebook()
        {
            _name = "Empty";
            _grades = new List<float>();
        }

        /// <summary>
        /// Adds a grade to the gradebook object
        /// </summary>
        /// <param name="grade"></param>
        public override void AddGrade(float grade)
        {
            _grades.Add(grade);
        }
        public override void WriteGrades(TextWriter destination)
        {
            for (int i = _grades.Count; i > 0; i--)
            {
                destination.WriteLine(_grades[i - 1]);
            }
        }

        /// <summary>
        /// Calculates the Highest, Lowest and Average grade of the Gradebook
        /// </summary>
        /// <returns></returns>
        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            // takes the sum of the grade and divides them by the number of grades
            stats.AverageGrade = sum / _grades.Count;
            return stats;
        }
    }
}
