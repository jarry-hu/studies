using System;

namespace MongoDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立连接
            var client = new MongoClient();
            //建立数据库
            var database = client.GetDatabase("TestDb");
            //建立collection
            var collection = database.GetCollection<BsonDocument>("foo");

            var document = new BsonDocument
            {
                {"name","MongoDB"},
                {"type","Database"},
                {"count",1},
                {"info",new BsonDocument{{"x",203},{"y",102}}}
            };
            //插入数据
            collection.InsertOne(document);

            var count = collection.Count(document);
            Console.WriteLine(count);

            //查询数据
            var document1 = collection.Find(document);
            Console.WriteLine(document1.ToString());

            //更新数据
            var filter = Builders<BsonDocument>.Filter.Eq("name", "MongoDB");
            var update = Builders<BsonDocument>.Update.Set("name", "Ghazi");

            collection.UpdateMany(filter, update);

            //删除数据
            var filter1 = Builders<BsonDocument>.Filter.Eq("count", 101);

            collection.DeleteMany(filter1);

            BsonDocument document2 = new BsonDocument();
            document2.Add("name", "MongoDB");
            document2.Add("type", "Database");
            document2.Add("count", "1");

            collection.InsertOne(document2);
            
        }
    }
}
