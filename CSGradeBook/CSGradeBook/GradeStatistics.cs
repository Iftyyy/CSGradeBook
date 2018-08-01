using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGradeBook
{
    public class GradeStatistics
    {
        // gradebook score fields to hold data
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
        public GradeStatistics()
        {
            // set values for highest and lowest value
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
    }
}
