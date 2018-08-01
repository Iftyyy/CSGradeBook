using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGradeBook
{
    public class Gradebook
    {
        private readonly List<float> grades;
        public Gradebook()
        {
            _name = "Empty";
            grades = new List<float>();
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
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
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
        }

        public event NameChangeDelegate NameChanged;

        /// <summary>
        /// Adds a grade to the gradebook object
        /// </summary>
        /// <param name="grade"></param>
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        /// <summary>
        /// Calculates the Highest, Lowest and Average grade of the Gradebook
        /// </summary>
        /// <returns></returns>
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum = sum += grade;
            }

            // takes the sum of the grade and divides them by the number of grades
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
    }
}
