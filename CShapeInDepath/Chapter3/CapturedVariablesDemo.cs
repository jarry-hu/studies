using System;
using System.Collections.Generic;

namespace Chapter3
{
    public class CapturedVariablesDemo
    {
        private string instanceField = "instance field";

        public Action<string> CreateAction(string methodParameter)
        {
            string methodLocal = "method local";
            string uncaptured = "uncaptured local";

            Action<string> action = lambdaParameter =>
            {
                string lambdaLocal = "lambda local";
                Console.WriteLine("Instance field: {0}", instanceField);
                Console.WriteLine("Method parameter: {0}", methodParameter);
                Console.WriteLine("Method local: {0}", methodLocal);
                Console.WriteLine("Lambda parameter: {0}", lambdaParameter);
                Console.WriteLine("Lambda local: {0}", lambdaLocal);
            };
            methodLocal = "modified method local";
            return action;
        }

        private class LambdaContext
        {
            public string text;

            public void Method()
            {
                Console.WriteLine(text);
            }
        }
        static List<Action> CreateActions()
        {
            List<Action> actions = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                LambdaContext context = new LambdaContext(); // < ------为每次循环都创建一个新的上下文
                context.text = string.Format("message {0}", i);
                actions.Add(context.Method); // < ------使用上下文创建一个action
            }
            return actions;
        }

        //static List<Action> CreateCountingActions()
        //{
        //    List<Action> actions = new List<Action>();
        //    int outerCounter = 0; // < ------两个委托捕获同一个变量
        //    for (int i = 0; i < 2; i++)
        //    {
        //        int innerCounter = 0; // < ------每次循环都创建一个新变量
        //        Action action = () =>
        //        {
        //            Console.WriteLine( // (本行及以下4行)计数器打印和自增
        //                "Outer: {0}; Inner: {1}",
        //                outerCounter, innerCounter);
        //            outerCounter++;
        //            innerCounter++;
        //        };
        //        actions.Add(action);
        //    }
        //    return actions;
        //}

        private class OuterContext // (本行及以下3行) 外层作用域的上下文
        {
            public int outerCounter;
        }

        private class InnerContext // (本行及以下3行) 包含外层上下文引用的内层作用域上下文
        {
            public OuterContext outerContext;
            public int innerCounter;

            public void Method() // <------ 用于创建委托的方法
            {
                Console.WriteLine(
                    "Outer: {0}; Inner: {1}",
                    outerContext.outerCounter, innerCounter);
                outerContext.outerCounter++;
                innerCounter++;
            }
        }

        static List<Action> CreateCountingActions()
        {
            List<Action> actions = new List<Action>();
            OuterContext outerContext = new OuterContext(); // < ------创建一个外层上下文
            outerContext.outerCounter = 0;
            for (int i = 0; i < 2; i++)
            {
                InnerContext innerContext = new InnerContext(); // (本行及以下2行)每次循环都创建一个内层上下文
                innerContext.outerContext = outerContext;
                innerContext.innerCounter = 0;
                Action action = innerContext.Method;
                actions.Add(action);
            }
            return actions;
        }

        // 其他代码

        //List<Action> actions = CreateCountingActions();
        //actions[0](); (本行及以下3行)每个委托调用两次
        //actions[0]();
        //actions[1]();
        //actions[1]();
    }
}
