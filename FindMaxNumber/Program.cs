

using System;
using System.Collections.Generic;
namespace FindMaxNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 12, 24, 48, 100, 176 };
            double[] doubleArray = { 99.9f, 122.3f, 33.44f, 65.4f };
            string[] stringArray = { "Apple", "Peach", "Banana", "mango", "watermelon", "pineapple" };

            Generic<int> intValue = new Generic<int>(intArray);
            Console.WriteLine(intValue.FindMaxNum());

            Generic<double> doubleValue = new Generic<double>(doubleArray);
            Console.WriteLine(doubleValue.FindMaxNum());

            Generic<string> stringValue = new Generic<string>(stringArray);
            Console.WriteLine(stringValue.FindMaxNum());
        }     

        
    }
}