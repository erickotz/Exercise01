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
    }
}
