using Chapter2;
using Chapter3;
using System;
using System.Collections.Generic;

namespace CShapeInDepath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chapter2();
            //Chapter3();
            //Chapter4();
            Chapter5();

            Console.Read();
        }

        private static void Chapter5()
        {
            throw new NotImplementedException();
        }

        private static void Chapter4()
        {
            //dynamic d = new object();
            //int invalid1 = "text".Substring(0, 1, 2, d);// < ------不存在接收4个参数的String.Substring方法
            //bool invalid2 = string.Equals<int>("foo", d);// < ------不存在泛型的String.Equals
            //string invalid3 = new string(d, "broken");// < ------不存在接收两个参数且第2个参数为字符串类型的String构造器
            //char invalid4 = "text"[d, d];// < ------不存在接收两个参数的String索引器
            //                             //编译器能够（但并不总是）得知上述特定例子会在运行

            // ---看不懂
            //dynamic database = new Database(connectionString);
            //var books = database.Books.SearchByAuthor("Holly Webb");
            //foreach (var book in books)


            // 以下声明均非法：
            //    class DynamicSequence : IEnumerable<dynamic>
            //class DynamicListSequence : IEnumerable<List<dynamic>>
            //class DynamicConstraint1<T> : IEnumerable<T> where T : dynamic
            //class DynamicConstraint2<T> : IEnumerable<T> where T : List<dynamic>
            // 以下声明均合法：
            //class DynamicList : List<dynamic>
            //class ListOfDynamicSequences : List<IEnumerable<dynamic>>
            //IEnumerable<dynamic> x = new List<dynamic>{ 1, 0.5 }.Select(x => x* 2);

        }
        /// <summary>
        /// 主要讲了Linq,收获最多的还是lamda的编译原理
        /// </summary>
        private static void Chapter3()
        {
            // Captured Variables

            //var demo = new CapturedVariablesDemo();
            //Action<string> action = demo.CreateAction("method argument");
            //action("lambda argument");

            // 测试 lamda反编译
            //int value = 5;
            //for (int i = 0; i < 6; i++)
            //{
            //    Action<int> act = test =>
            //    {
            //        value = test;
            //        Console.WriteLine(test);
            //        int h = 1;
            //        Console.WriteLine(h);
            //    };
            //}
            //value = 6;
            //Console.WriteLine(value);
            //Action<int> act1 = test =>
            //{
            //    value = test;
            //    Console.WriteLine(test);
            //    int h = 2;
            //    Console.WriteLine(h);
            //};
            //act.Invoke(3);
            //act.Invoke(36);
            //act1.Invoke(4);


            //            Expression<Func<int, int, int>> adder = (x, y) => x + y;
            //            Func<int, int, int> executableAdder = adder.Compile(); < ------将表达式树编译成委托
            //Console.WriteLine(executableAdder(2, 3));
        }
        private static void Chapter2()
        {
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
            //var enumerable = Enumerable.GenerateIntegers(10);
            //foreach (var item in enumerable)
            //{a'd'sa's'd'fa's'd'fa's'f

            //}
        }


    }
}
