using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBuru.Domain.Enums;
using TaskBuru.Domain.Models.TaskSimple;

namespace TaskBuru.Domain.Models.User
{
    internal class PersonBuruModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string? Names{ get; set; }
        public string? LastNames{ get; set; }
        public int Age { get; set; }

    }
}
