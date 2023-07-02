using MongoDB.Bson;
using MongoDB.Driver;
using FlightPlanAPI.Models;

namespace FlightPlanAPI.Data
{
    public class MongoDbDatabase
    {
       private IMongoCollection<BsonDocument> GetCollection(
            string databaseName, string collectionName)
        {
            var client = new MongoClient();
            var database = client.GetDatabase(databaseName);

        }
    }
}
