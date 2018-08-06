using System;
using System.Collections;
using System.IO;

namespace CSGradeBook
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
        public abstract IEnumerator GetEnumerator();

        /// <summary>
        /// Name event where name is verified and name is changed
        /// </summary>
        protected string _name;
        public string Name
        {
            get => _name;
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
