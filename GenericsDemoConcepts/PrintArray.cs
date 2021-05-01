using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemoConcepts
{
    class PrintArray
    {
        /// <summary>
        /// UC1
        /// </summary>
        /// <param name="arr"></param>
        public static void ToPrintInteger(int[] arr)
        {
            Console.WriteLine("\nDisplay integer array elements ");
            foreach (int element in arr)
            {
                Console.WriteLine(element + "\t");
            }
        }
        public static void ToPrintDouble(double[] arr)
        {
            Console.WriteLine("\nDisplaying double array elements ");

            foreach (double element in arr)
            {
                Console.WriteLine(element + "\t");
            }
        }
        public static void ToPrintCharacter(char[] arr)
        {
            Console.WriteLine("\nDisplaying character array elements ");

            foreach (char element in arr)
            {
                Console.WriteLine(element + "\t");
            }
        }
        /// <summary>
        /// UC2
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void ToPrintArray<T>(T[] array)
        {
            Console.WriteLine("\nDisplaying character array elements ");

            foreach (T element in array)
            {
                Console.WriteLine(element + "\t");
            }
        }
    }
}
