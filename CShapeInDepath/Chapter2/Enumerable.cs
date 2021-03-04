using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    public class Enumerable
    {
        //public static IEnumerable<int> CreateSimpleIterator()
        //{
        //    yield return 10;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        yield return i;
        //    }
        //    yield return 20;
        //}

        //public static IEnumerable<int> Fibonacci()
        //{
        //    int current = 0;
        //    int next = 1;
        //    while (true)
        //    {
        //        yield return current;
        //        int oldCurrent = current;
        //        current = next;
        //        next = next + oldCurrent;
        //    }
        //}

        public static IEnumerable<int> GenerateIntegers(int count)
        {
            try
            {
                // 本质上就是通过Switch(state)将代码拆分成很多段,
                // 通过MoveNext函数改变State, 
                // yield return 值，用 current字段记录  每次执行通过MoveNext函数会根据state的值来改变当前值,（具体看反编译的源码）
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Yielding{0}", i);
                    yield return i;
                    int doubled = i * 2;
                    Console.WriteLine("Yielding{0}",doubled);
                    yield return i * 2;
                }
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }
    }
}
