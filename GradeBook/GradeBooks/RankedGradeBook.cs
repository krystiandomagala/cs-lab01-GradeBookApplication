using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5) 
                throw new InvalidOperationException("There are less than 5 students.");

            double twentyProcentsOfStudents = Students.Count * 0.2;


            return '0';
        }
    }
}
