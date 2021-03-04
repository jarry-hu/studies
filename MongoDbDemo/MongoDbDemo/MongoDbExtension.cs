using NUnit.Compatibility;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbDemo
{
    internal static class MongoDbExtension
    {
        /// <summary>
        /// 获取特性信息
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static MongoAttribute GetMongoAttribute(this Type type)
        {
            return AttributeHelper<MongoAttribute>.GetAttribute(type);
        }
    }
}
