using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chapter7
{
    public class CallerAttribute
    {
        public static void ShowInfo(
            [CallerFilePath] string file = null,
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = null)
        {
            Console.WriteLine("{0}:{1}-{2}", file, line, member);
        }
        public static void ShowLine(string message, //即将调用的、使用行号的方法
    [CallerLineNumber] int line = 0)
        {
            Console.WriteLine("{0}: {1}", line, message);
        }

        public static int GetLineNumber(//(本行及以下4行) 第2种迂回方案的帮助方法

            [CallerLineNumber] int line = 0)
        {
            return line;
        }

        public abstract class BaseClass
        {
            protected BaseClass( //<------ 基类构造器使用调用方信息attribute
                [CallerFilePath] string file = "Unspecified file",
                [CallerLineNumber] int line = -1,
                [CallerMemberName] string member = "Unspecified member")
            {
                Console.WriteLine("{0}:{1} - {2}", file, line, member);
            }
        }

        public class Derived1 : BaseClass { } //<------ 无参构造器是隐式添加的

        public class Derived2 : BaseClass
        {
            public Derived2() { } //<------ 隐式调用base()的构造器
        }

        public class Derived3 : BaseClass
        {
            public Derived3() : base() { } //<------ 显式调用base()的构造器
        }
        [AttributeUsage(AttributeTargets.All)]
        public class MemberDescriptionAttribute : Attribute
        {
            public MemberDescriptionAttribute(
                [CallerFilePath] string file = "Unspecified file",
                [CallerLineNumber] int line = 0,
                [CallerMemberName] string member = "Unspecified member")
            {
                File = file;
                Line = line;
                Member = member;
            }

            public string File { get; }
            public int Line { get; }
            public string Member { get; }

            public override string ToString() =>
                $"{Path.GetFileName(File)}:{Line} - {Member}";
        }
        [MemberDescription] //(本行及以下1行) 应用了attribute的类
        public class CallerNameInAttribute
        {
            [MemberDescription]
            // (本行及以下3行) 通过各种方式对方法应用attribute
            public void Method<[MemberDescription] T>(
        [MemberDescription] int parameter)
            { }
        }
    }

}
