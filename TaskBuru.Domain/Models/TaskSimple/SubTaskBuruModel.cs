using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBuru.Domain.Models.TaskSimple
{
    public class SubTaskBuruModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public ObjectId IdTask { get; set; }
        public string? TitleSubTask { get; set; }
        public string? DescriptionSubtask { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public bool? Check { get; set; } = false;
    }
}
