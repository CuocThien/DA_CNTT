using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Class
{
    public class CMongoCRUD
    {
        private IMongoDatabase db;
        public CMongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }
        public List<T> Read<T>(string table)
        {
            var collection = this.db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }
        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }    
        public T ReadByObjectId<T>(string table, ObjectId id)
        {
            var collection = this.db.GetCollection<T>(table);
            return collection.Find(new BsonDocument("_id", id)).SingleAsync().Result;
        }
        public void DeleteByObjectId<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);
            collection.DeleteOne(filter);
        }

        public void Update<T>(string table, ObjectId id, T record)
        {
            var collection = db.GetCollection<T>(table);
#pragma warning disable CS0618 // Type or member is obsolete
            var result = collection.ReplaceOne(
                    new BsonDocument("_id", id),
                    record,
                    new UpdateOptions
                    {
                        IsUpsert = true
                    }
                );
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
