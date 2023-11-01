using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using TaskBuru.Domain.Enums;

namespace TaskBuru.Domain.Models.TaskSimple
{
    public class TaskBuruModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string? TitleTask { get; set; }
        public TaskTypeBuruEnum? TaskType { get; set; }
        public string? DescriptionTask { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public List<SubTaskBuruModel>? SubTask { get; set; } 
        public bool? Check { get; set; } = false; 
    }
}
