using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumber
{
    internal class FindMax
    {
        public static int Maximuminteger(int numOne, int numTwo, int numThree)
        {
            int maximum = numOne;
            if (numTwo.CompareTo(maximum) > 0)
            {
                maximum = numTwo;
                Console.WriteLine("maximum number is " + numTwo);
            }
            if (numThree.CompareTo(maximum) > 0)
            {
                maximum = numThree;
                Console.WriteLine("maximum number is " + numThree);
            }
            return maximum;
        }
        public static double MaximumFloat(double numOne, double numTwo, double numThree)
        {
            double maximum = numOne;
            if (numTwo.CompareTo(maximum) > 0)
            {
                maximum = numTwo;
            }
            if (numThree.CompareTo(maximum) > 0)
            {
                maximum = numThree;
            }
            return maximum;
        }
    }
}
