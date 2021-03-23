using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Runtime.CompilerServices;

namespace Chapter4
{
    // 暂时看不懂
    public class DynamicTypingDecompiled
    {
        private static class CallSites //<------ 缓存调用位置
        {
            public static CallSite<Func<CallSite, object, int, object>> method;
            public static CallSite<Func<CallSite, object, string>> conversion;

            static void Main()
            {
                object text = "hello world";
                if (CallSites.method == null) // < ------根据需要为方法创建调用位置
                {
                    CSharpArgumentInfo[] argumentInfo = new[]
                    {
                        CSharpArgumentInfo.Create(
                          CSharpArgumentInfoFlags.None, null),
                        CSharpArgumentInfo.Create(
                          CSharpArgumentInfoFlags.Constant |
                            CSharpArgumentInfoFlags.UseCompileTimeType,
                          null)
                      };
                    CallSiteBinder binder =
                      Binder.InvokeMember(CSharpBinderFlags.None, "Substring",
                        null, typeof(DynamicTypingDecompiled), argumentInfo);
                    CallSites.method =
                      CallSite<Func<CallSite, object, int, object>>.Create(binder);
                }

                if (CallSites.conversion == null) //< ------根据需要为转换创建调用位置
                {
                    CallSiteBinder binder =
                      Binder.Convert(CSharpBinderFlags.None, typeof(string),
          typeof(DynamicTypingDecompiled));
                    CallSites.conversion =
                      CallSite<Func<CallSite, object, string>>.Create(binder);
                }
                object result = CallSites.method.Target(//(本行及以下1行)调起方法调用位置

                  CallSites.method, text, 6);

                string str = //< ------调起转换调用位置
      CallSites.conversion.Target(CallSites.conversion, result);
            }
        }
    }
}
}
