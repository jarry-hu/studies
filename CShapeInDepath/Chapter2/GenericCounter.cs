using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    public class GenericCounter<T>
    {
        private static int value;
        static GenericCounter()
        {
            Console.WriteLine("Initializing counter for {0}", typeof(T));
        }

        public static void Increament()
        {
            value++;
        }

        public static void Display()
        {
            Console.WriteLine("Counter for {0}:{1}", typeof(T),value);
        }
    }
}
