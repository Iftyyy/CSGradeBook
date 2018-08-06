using System;

namespace CSGradeBook
{
    public class GradeStatistics
    {
        public string LetterGrade
        {
            get
            {
                string result;
                if (Math.Round(AverageGrade) >= 90)
                {
                    result = "A";
                }
                else if (Math.Round(AverageGrade) >= 80)
                {
                    result = "B";
                }
                else if (Math.Round(AverageGrade) >= 70)
                {
                    result = "C";
                }
                else if (Math.Round(AverageGrade) >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }
        }
        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "failing";
                        break;
                }

                return result;
            }

        }

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
