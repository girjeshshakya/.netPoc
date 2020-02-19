using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Poc.Students.DataAccessLogic
{
    public class Student
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Place { get; set; }
        public string Username { get; set; }

    }
    public class StudentDao : IStudentDao
    {
        public StudentDao()
        {
        }

        public string GetStudents()
        {


            var client = new MongoClient("mongodb+srv://girjesh113:harsh1234@girjesh-pjnrn.mongodb.net/test?retryWrites=true&w=majority");
            var collection = client.GetDatabase("Students").GetCollection<Student>("Students");
            Expression<Func<Student, bool>> expression = (m => m.name == "girjesh kumar";
            var list = collection.Find(expression).ToList();






            //var client = new MongoClient("mongodb+srv://girjesh113:harsh1234@girjesh-pjnrn.mongodb.net/test?retryWrites=true&w=majority");
            //var database = client.GetDatabase("Students");
            //var filter = Builders<Student>.Filter.Eq("student.name", "girjesh kumar");
           
            //    var collection = database.GetCollection<Student>("student");
            //var output = collection.FindOneAndDelete(filter);

            //var abc = database.GetCollection<Student>("student").Find(filter);

            //var query = Query<Student>.EQ(e => e.name, "girjesh kumar");
            //var entity = collection.FindOne(query);
            //using (IAsyncCursor<BsonDocument> cursor = await collection.FindAsync(new BsonDocument()))
            //{
            //    while (await cursor.MoveNextAsync())
            //    {
            //        IEnumerable<BsonDocument> batch = cursor.Current;
            //        foreach (BsonDocument document in batch)
            //        {
            //            Console.WriteLine(document);
            //            Console.WriteLine();
            //        }
            //    }
            //}

            //System.Collections.Generic.List<MongoDB.Bson.BsonDocument> dbs = client.ListDatabases().ToList();

            //foreach(var db in dbs){

            //  Console.WriteLine(db.ToString());

            //}



            //         var client = new MongoClient("mongodb://girjesh113:harsh1234@girjesh-shard-00-00-pjnrn.mongodb.net:27017,girjesh-shard-00-01-pjnrn.mongodb.net:27017,girjesh-shard-00-02-pjnrn.mongodb.net:27017/Students?ssl=true&replicaSet=girjesh-shard-0&authSource=admin&retryWrites=true&w=majority");
            //       var database = client.GetDatabase("Students");



            return "Girjesh";
        }



       
    }


   
}
