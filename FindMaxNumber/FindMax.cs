using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumber
{
    public class Generic<T> where T : IComparable
    {
        public T[] arrayValue;

        public Generic(T[] array)
        {
            this.arrayValue = array;
        }
        public T[] Sort(T[] array)
        {
            Array.Sort(array);
            return array;
        }
        public T maxarray(T[] array)
        {
            var sortedValue = Sort(array);
            return sortedValue[^1];
        }
        public T FindMaxNum()
        {
            var maximum = maxarray(arrayValue);
            return maximum;
        }
        public void print()//uc-5
        {
            var maximum = maxarray(arrayValue);
            Console.WriteLine("Maximum is = " + maximum);
        }
    }
}
