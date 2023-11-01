using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBuru.Domain.Models.TaskConstants
{
    internal class ConstantSubTaskBuruModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string TitleSubTask { get; set; }
        public string DescriptionSubTask { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
