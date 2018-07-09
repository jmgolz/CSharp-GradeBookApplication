using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook :BaseGradeBook
    {
			public RankedGradeBook(string name) : base(name)
			{
				 Type = Enums.GradeBookType.Ranked;
			}

			public override char GetLetterGrade(double averageGrade)
			{
				 if(Students.Count < 5){
						throw new InvalidOperationException("Ranked grading requires at least 5 students.");
				 }

				 double computedAverageGrade = 0.0d;

				 foreach (var student in Students)
				 {
						computedAverageGrade += student.AverageGrade;
				 }

				 computedAverageGrade = computedAverageGrade / Students.Count;

				 if(computedAverageGrade >= 0.8d){
						return 'A';
				 } else if (computedAverageGrade < 0.8d && computedAverageGrade >= 0.6d) {
						return 'B';
				 } else if (computedAverageGrade < 0.6d && computedAverageGrade >= 0.4d) {
						return 'C';
				 } else if(computedAverageGrade < 0.4d && computedAverageGrade >= 0.2d) {
						return 'D';
				 } 
				 
				 return 'F';
			}
    }
}
