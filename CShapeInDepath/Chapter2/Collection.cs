using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Chapter2
{
    public class Collection
    {
        #region string[]：需要预定大小
        //public static string[] GenerateNames()
        //{
        //    var names = new string[4];
        //    names[0] = "Gamma";
        //    names[1] = "Vlissides";
        //    names[2] = "Johnson";
        //    names[3] = "Helm";
        //    return names;
        //}

        //public static void PrintNames(string[] names)
        //{
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        #endregion

        #region ArrayList：使用object 对象不对应时会有InvilidCastException异常 拆箱 装箱的性能
        //public static ArrayList GenerateNames()
        //{
        //    var names = new ArrayList();
        //    names.Add("Gamma");
        //    names.Add("Vlissides");
        //    names.Add("Johnson");
        //    names.Add("Helm");
        //    return names;
        //}

        //public static void PrintNames(ArrayList names)
        //{
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        #endregion

        #region StringCollection：只能使用string
        //public static StringCollection GenerateNames()
        //{
        //    StringCollection names = new StringCollection();
        //    names.Add("Gamma");
        //    names.Add("Vlissides");
        //    names.Add("Johnson");
        //    names.Add("Helm");
        //    return names;
        //}

        //public static void PrintNames(StringCollection names)
        //{
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        #endregion

        #region List<T>
        public static List<string> GenerateNames()
        {
            var names = new List<string>();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }

        public static void PrintNames(List<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        #endregion
    }
}
