﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5) 
                throw new InvalidOperationException("There are less than 5 students.");

            if (averageGrade > 80)
                return 'A';
            if (averageGrade > 60)
                return 'B';
            if (averageGrade > 40)
                return 'C';
            if (averageGrade > 20)
                return 'D';

            return 'F';
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStatistics();

        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStudentStatistics(name);
        }
    }
}
