using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiBuruTasks.Models.TaskSimple
{
    public class ModelSubTaskBuru
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string TitleSubTask { get; set; }
        public string? DescriptionSubtask { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public bool? Check { get; set; }
    }
}
