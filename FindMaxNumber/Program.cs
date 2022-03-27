using System;

namespace FindMaximumNumber
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int numOne = 50;
            int numTwo = 100;
            int numThree = 25;

            int maxnum = GetMaximum(numOne, numTwo, numThree);
            Console.WriteLine(maxnum);

        }
        public static int GetMaximum(int numOne, int numTwo, int numThree)
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
    }
}