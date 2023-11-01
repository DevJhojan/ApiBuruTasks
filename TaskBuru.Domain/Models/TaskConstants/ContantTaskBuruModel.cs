using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBuru.Domain.Enums;

namespace TaskBuru.Domain.Models.TaskConstants
{
    internal class ContantTaskBuruModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string TitleTask { get; set; }
        public TaskTypeBuruEnum TaskType { get; set; }
        public string? Description { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public ConstantSubTaskBuruModel[]? ConstantSubTask { get; set; }
    }
}
