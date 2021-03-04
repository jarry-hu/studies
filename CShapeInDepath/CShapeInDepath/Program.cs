using Chapter2;
using System;
using System.Collections.Generic;

namespace CShapeInDepath
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chapter2
            // 测试泛型
            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(10);
            //numbers.Add(20);
            //var firstTwo = Generic.CopyAtMost<int>(numbers, 2);
            //Console.WriteLine(firstTwo.Count);

            // 探索泛型中的静态字段
            //GenericCounter<string>.Increament();
            //GenericCounter<string>.Increament();
            //GenericCounter<string>.Display();
            //GenericCounter<int>.Display();
            //GenericCounter<int>.Increament();
            //GenericCounter<int>.Display();

            // 可空类型 Nullable<int> == int?
            //var noValue = new Nullable<int>();
            //object noValueBoxed = noValue;
            //Console.WriteLine(noValueBoxed == null);

            //var someValue = new Nullable<int>(5);
            //object someValueBoxed = someValue;

            //Console.WriteLine(someValue.GetType());

            // 可空类型无法逻辑运算
            //bool? b1 = true;
            //bool? b2 = false;
            // var b3 = b1 || b2; 语法错误

            // IEnumerable
            //IEnumerable<int> enumerable = Enumerable.CreateSimpleIterator();
            //using (var enumerator = enumerable.GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //    {
            //        int value = enumerator.Current;
            //        Console.WriteLine(value);
            //    }
            //}

            // 斐波那契数列
            //foreach (var value in Enumerable.Fibonacci())
            //{
            //    Console.WriteLine(value);
            //    if (value>1000)
            //    {
            //        break;
            //    }
            //}

            // 反编译迭代器
            var enumerable = Enumerable.GenerateIntegers(10);
            foreach (var item in enumerable)
            {

            }
            #endregion

            Console.Read();
        }
    }
}
