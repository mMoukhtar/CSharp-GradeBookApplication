using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(string name): base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            } 
            else
            {
                switch (averageGrade)
                {
                    case var d when d > 80.0:
                        return 'A';
                    case var d when d > 60.0:
                        return 'B';
                    case var d when d > 40.0:
                        return 'C';
                    case var d when d > 20.0:
                        return 'D';
                }
            }
            return 'F';
        }
    }
}
