using System;

namespace GenericsDemoConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 10, 20, 30, 40 };
            double[] doubleArr = { 10.2, 20.4, 30.5, 40.4 };
            char[] charArr = { 'H', 'E', 'L', 'L', 'O' };
            //PrintArray.ToPrintInteger(intArr);
            //PrintArray.ToPrintDouble(doubleArr);
            //PrintArray.ToPrintCharacter(charArr);

            //PrintArray.ToPrintArray<int>(intArr);
            //PrintArray.ToPrintArray<double>(doubleArr);
            //PrintArray.ToPrintArray<char>(charArr);

            new PrintArrayWithGenerics<int>(intArr).ToPrintArray();
            new PrintArrayWithGenerics<double>(doubleArr).ToPrintArray();
            new PrintArrayWithGenerics<char>(charArr).ToPrintArray();





            Console.ReadLine();
        }
    }
}
