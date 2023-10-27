using ApiBuruTasks.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiBuruTasks.Models.TaskSimple
{
    public class ModelTaskBuru
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string TitleTask { get; set; }
        public EnumTaskTypeBuru? TaskType { get; set; }
        public string? DescriptionTask { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public ModelSubTaskBuru[]? SubTask { get; set; }
        public bool? Check { get; set; }
    }
}
