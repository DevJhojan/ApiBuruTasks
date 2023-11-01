using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiBuruTasks.Models.ModelShared
{
    public class DailyBuruModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DateDay { get; set; }
    }
}
