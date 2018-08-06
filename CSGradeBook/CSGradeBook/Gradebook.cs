using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGradeBook
{
    public class Gradebook
    {
        private readonly List<float> _grades;
        public Gradebook()
        {
            _name = "Empty";
            _grades = new List<float>();
        }
        
        /// <summary>
        /// Adds a grade to the gradebook object
        /// </summary>
        /// <param name="grade"></param>
        public void AddGrade(float grade)
        {
            _grades.Add(grade);
        }
        public void WriteGrades(TextWriter destination)
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
        public GradeStatistics ComputeStatistics()
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

        /// <summary>
        /// Name event where name is verified and name is changed
        /// </summary>
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (_name != value && NameChanged != null)
                {
                    NamedChangedEventArgs args = new NamedChangedEventArgs
                    {
                        ExistingName = _name,
                        NewName = value
                    };

                    NameChanged(this, args);
                }
                _name = value;
            }
        }
        public event NameChangeDelegate NameChanged;
    }
}
