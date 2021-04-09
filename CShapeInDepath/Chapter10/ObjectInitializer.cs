using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter10
{
    public class ObjectInitializer
    {
        public static void Test()
        {
            string text = "This text needs truncating";
            StringBuilder builder = new StringBuilder(text)
            {
                Length = 10 //< ------设置Length属性来切分builder
            };
            builder[9] = '\u2026'; //< ------将最后一个字符修改为...
            Console.OutputEncoding = Encoding.UTF8; //< ------确保Console支持Unicode编码
            Console.WriteLine(builder); //< ------打印 builder的内容

            //var collectionInitializer = new Dictionary<string, int> //< ------C# 3的普通集合初始化器
            //{
            //    { "A", 20 },
            //    { "B", 30 },
            //    { "B", 40 }
            //};

            var objectInitializer = new Dictionary<string, int> //< ------C# 6使用索引器的对象初始化器
            {
                ["A"] = 20,
                ["B"] = 30,
                ["B"] = 40
            };
        }

    }



    public sealed class SchemalessEntity: IEnumerable<KeyValuePair<string, object>>
    {
        private readonly IDictionary<string, object> properties =
       new Dictionary<string, object>();

        public string Key { get; set; }
        public string ParentKey { get; set; }

        public object this[string propertyKey]
        {
            get { return properties[propertyKey]; }
            set { properties[propertyKey] = value; }
        }

        public void Add(string propertyKey, object value)
        {
            properties.Add(propertyKey, value);
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() =>
            properties.GetEnumerator();


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public static class StringListExtensions
    {
        public static void Add(
        this List<string> list, int value, int count = 1)
        {
            list.AddRange(Enumerable.Repeat(value.ToString(), count));
        }
    }
}
