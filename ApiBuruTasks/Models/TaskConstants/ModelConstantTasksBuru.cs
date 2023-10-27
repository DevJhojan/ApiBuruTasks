using ApiBuruTasks.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiBuruTasks.Models.TaskConstants
{
    public class ModelConstantTasksBuru
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string TitleTask { get; set; }
        public EnumTaskTypeBuru TaskType { get; set; }
        public string? Description { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public ModelConstantSubTaskBuru[]? ConstantSubTask { get; set; }

    }
}
