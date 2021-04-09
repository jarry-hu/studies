using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using static System.Linq.Queryable;


namespace Chapter10
{
    public class UsingStatic
    {
        public static  void Test()
        {
            var query = new[] { "a", "bc", "d" }.AsQueryable(); //< ------创建一个IQueryable<string>

            Expression<Func<string, bool>> expr = //(本行及以下2行)创建一个委托和表达式树
                x => x.Length > 1;
            Func<string, bool> del = x => x.Length > 1;

            var valid = query.Where(expr); //< ------合法： 使用 Queryable.Where

            // var invalid = query.Where(del); //< ------非法：查找范围内不存在接受委托为参数的Where方法
        }
    }
}
