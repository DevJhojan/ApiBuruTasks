using MongoDB.Bson;
using MongoDB.Driver;
using TaskBuru.Applications.Repositories.RepositoriesSimple;
using TaskBuru.Applications.Interfaces.ITaskSimple;
using TaskBuru.Domain.Models.TaskSimple;
using System;

namespace TaskBuru.Applications.Collections.CollectionTaskSiple
{
    public class SubTaskBuruRepositoryCollection : ISubTaskBuruRepositoryCollection
    {
        internal TaskDataBaseRepository _taskRepository = new TaskDataBaseRepository();
        private IMongoCollection<SubTaskBuruModel> subTaskBuruCollection;
        private ITaskBuruRepositoryCollection taskDataBase = new TaskBuruRepositoryCollection();
        public SubTaskBuruRepositoryCollection() {
            subTaskBuruCollection = _taskRepository.taskDataBase
                .GetCollection<SubTaskBuruModel>("SubTaskBuru");
        }
        public async Task DeleteSubTaskBuru(string id, string idTask)
        {
            var task = await taskDataBase.GetTaskBuruById(idTask);
            
            if (task.SubTask == null)  return;

            var Id = new MongoDB.Bson.ObjectId(id);

            int i = task.SubTask.FindIndex(subTask => subTask.Id == Id);

            if(i >= 0)task.SubTask.RemoveAt(i);

            var filterSubTaskBuru = Builders<SubTaskBuruModel>
            .Filter.Eq(subTaskBuru => subTaskBuru.Id, new ObjectId(id));

            await taskDataBase.UpdateTaskBuru(task);

            await subTaskBuruCollection.DeleteOneAsync(filterSubTaskBuru);
        }

        public async Task<List<SubTaskBuruModel>> GetAllSubTaskBuru()
        {
            return await subTaskBuruCollection
                .FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<SubTaskBuruModel> GetSubTaskBuruById(string id)
        {
            return await subTaskBuruCollection
                .FindAsync(new BsonDocument { { "_id", new ObjectId(id) } })
                .Result.FirstAsync();
        }

        public async Task<SubTaskBuruModel> GetSubTaskBuruById(string id, string idTask)
        {
            return await subTaskBuruCollection
                .FindAsync(new BsonDocument { { "_id", new ObjectId(id) },{ "IdTask", new ObjectId(idTask) } })
                .Result.FirstAsync();
        }

        public async Task InsertSubTaskBuru(SubTaskBuruModel subTaskBuru, string idTask)
        {
            
            
            await subTaskBuruCollection.InsertOneAsync(subTaskBuru);

            var task = await taskDataBase.GetTaskBuruById(idTask);
            if (task.SubTask != null) 
            {
                task.SubTask.Add(subTaskBuru);
                await taskDataBase.UpdateTaskBuru(task);
            }
            else return;
        }

        public async Task UpdateSubTaskBuru(SubTaskBuruModel subTaskBuru)
        {
            var filterTaskburu = Builders<SubTaskBuruModel>
                .Filter.Eq(subTaskBuruFilter => subTaskBuruFilter.Id, subTaskBuru.Id);
            await subTaskBuruCollection.ReplaceOneAsync(filterTaskburu, subTaskBuru);
        }
    }
}
 