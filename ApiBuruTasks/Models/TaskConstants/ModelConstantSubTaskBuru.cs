using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiBuruTasks.Models.TaskConstants
{
    public class ModelConstantSubTaskBuru
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string TitleSubTask { get; set; }
        public string DescriptionSubTask { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
