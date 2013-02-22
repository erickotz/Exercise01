using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Class1
    {
        public bool AddStudent(string studentName, int studentId)
        {
            // Need to a code here to return false if this fails
            return true;
        }

        public bool AddTest(string testName, int testId)
        {
            // Need to a code here to return false if this fails
            return true;
        }

        public decimal Average(decimal[] input)
        {
            return input.Average();
        }

        public decimal Max(decimal[] input)
        {
            return input.Max();
        }

        public decimal Min(decimal[] input)
        {
            return input.Min();
        }

        public decimal Median(decimal[] input)
        {
            Array.Sort(input);
            // Deal with even-sized arays
            if (input.Length % 2 == 0)
            {
                return input[(int)(input[input.Length / 2] + input[input.Length / 2 + 1]) / 2];
            }

            // Deal with odd-sized arays
            else
            {
                return input[(int)(input[(input.Length / 2)])];
            }
        }
        public decimal FindFinalScore(int studentType, decimal[] studentGrades)
        {
            // Acceptable values for studentType are:
            // 1 == Special Needs student
            // 2 == Advanced student
            // 3 == Regular Student

            switch (studentType)
            {
                    case 1:
                        return (FindFinalScoreForSpecialNeedsStudent(studentGrades[0],studentGrades[1],studentGrades[2],studentGrades[3],studentGrades[4],studentGrades[5],studentGrades[6],studentGrades[7],studentGrades[8]));
                    case 2:
                        return (FindFinalScoreForAdvancedStudent(studentGrades[0],studentGrades[1],studentGrades[2],studentGrades[3],studentGrades[4],studentGrades[5],studentGrades[6],studentGrades[7],studentGrades[8]));
                    default:
                        return (FindFinalScoreForRegularStudent(studentGrades[0],studentGrades[1],studentGrades[2],studentGrades[3],studentGrades[4],studentGrades[5],studentGrades[6],studentGrades[7],studentGrades[8]));
            }
        }

        public decimal FindFinalScoreForSpecialNeedsStudent(decimal finalTest, decimal test1, decimal test2, decimal quiz1, decimal popQuiz1, decimal popQuiz2, decimal popQuiz3, decimal popQuiz4, decimal popQuiz5)
       {
            // Sets the weights of the grades
            const decimal finalWeight = 0;
            const decimal testWeight = 20;
            const decimal quizWeight = 10;
            const decimal popQuizWeight = 2;

            return ((finalTest * finalWeight + test1 * testWeight + test2 * testWeight + quiz1 * quizWeight + popQuiz1 * popQuizWeight + popQuiz2 * popQuizWeight + popQuiz3 * popQuizWeight + popQuiz4 * popQuizWeight + popQuiz5 * popQuizWeight) / (finalWeight + testWeight * 2 + quizWeight + popQuizWeight * 5));
        }

        public decimal FindFinalScoreForAdvancedStudent(decimal finalTest, decimal test1, decimal test2, decimal quiz1, decimal popQuiz1, decimal popQuiz2, decimal popQuiz3, decimal popQuiz4, decimal popQuiz5)
        {
            // Sets the weights of the grades
            const decimal finalWeight = 100;
            const decimal testWeight = 0;
            const decimal quizWeight = 0;
            const decimal popQuizWeight = 0;

            return ((finalTest * finalWeight + test1 * testWeight + test2 * testWeight + quiz1 * quizWeight + popQuiz1 * popQuizWeight + popQuiz2 * popQuizWeight + popQuiz3 * popQuizWeight + popQuiz4 * popQuizWeight + popQuiz5 * popQuizWeight) / (finalWeight + testWeight * 2 + quizWeight + popQuizWeight * 5));
         }

        public decimal FindFinalScoreForRegularStudent(decimal finalTest, decimal test1, decimal test2, decimal quiz1, decimal popQuiz1, decimal popQuiz2, decimal popQuiz3, decimal popQuiz4, decimal popQuiz5)
        {
            // Sets the weights of the grades
            const decimal finalWeight = 50;
            const decimal testWeight = 20;
            const decimal quizWeight = 10;
            const decimal popQuizWeight = 2;

            return ((finalTest * finalWeight + test1 * testWeight + test2 * testWeight + quiz1 * quizWeight + popQuiz1 * popQuizWeight + popQuiz2 * popQuizWeight + popQuiz3 * popQuizWeight + popQuiz4 * popQuizWeight + popQuiz5 * popQuizWeight) / (finalWeight + testWeight * 2 + quizWeight + popQuizWeight * 5));
        } 
    }
}
