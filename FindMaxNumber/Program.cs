

using System;
using System.Collections.Generic;
namespace FindMaxNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int numOne = 50;
            int numTwo = 100;
            int numThree = 25;

            int maxnumber = FindMax.Maximuminteger( numOne, numTwo, numThree);

            double num_1 = 12.1;
            double num_2 = 24.2;
            double num_3 = 48.3;

            double maximumDouble = FindMax.MaximumFloat(12.1, 24.2, 48.3);
            Console.WriteLine("maximum number is " + maximumDouble);

            string firststring = "apple";
            string secondstring = "banana";
            string thirdstring = "peach";
            string maxstring = FindMax.MaximumString("apple", "banana", "peach");
            Console.WriteLine("maximum string is " + maxstring);
        }

    }
}