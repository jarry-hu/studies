using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbDemo
{
    class MongoEntity
    {
        public MongoEntity()
        {
            _id = Guid.NewGuid().ToString("N");
        }

        public string _id { get; set; }
    }
}
