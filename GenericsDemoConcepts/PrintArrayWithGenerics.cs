using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemoConcepts
{
    class PrintArrayWithGenerics<E>
    {
        E[] array;
        public PrintArrayWithGenerics(E[] array)
        {
            this.array = array;
        }
        public void ToPrintArray()
        {
            Console.WriteLine("\nDisplaying array elements ");

            foreach (var element in array)
            {
                Console.WriteLine(element + "\t");
            }
        }
    }
}
