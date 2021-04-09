using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    public static class Entrance
    {
        class person
        {
            public string Name { get; set; }
        }
        public static void Chapter10Main()
        {
            ObjectInitializer.Test();

            List<string> strings = new List<string>
            {
                10,
                "hello",
                { 20,30 }
            };

            //person ps = null;
            //ps?.Name = "11";
        }
    }
}
