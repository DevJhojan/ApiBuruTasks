using ApiBuruTasks.Interfaces.ITaskSimple;
using ApiBuruTasks.Models.TaskSimple;
using ApiBuruTasks.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ApiBuruTasks.Collections.CollectionTaskSiple
{
    public class TaskBuruCollection : ITaskBuruCollection
    {
        internal TaskDataBaseRepository _taskRepository = new TaskDataBaseRepository();
        private IMongoCollection<ModelTaskBuru> taskBuruCollection;

        public TaskBuruCollection()
        {
            taskBuruCollection = _taskRepository.taskDataBase
                .GetCollection<ModelTaskBuru>("TaskBuru");
        }

        public async Task DeleteTaskBuru(string id)
        {
            var filterTaskBuru = Builders<ModelTaskBuru>
                .Filter.Eq(taskBuru => taskBuru.Id, new ObjectId(id));
            await taskBuruCollection.DeleteOneAsync(filterTaskBuru);
        }

        public async Task<List<ModelTaskBuru>> GetAllTaskBuru()
        {
            return await taskBuruCollection
                .FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<ModelTaskBuru> GetTaskBuruById(string id)
        {
            return await taskBuruCollection
                .FindAsync(new BsonDocument { { "_id", new ObjectId(id) } })
                .Result.FirstAsync();
        }

        public async Task InsertTaskBuru(ModelTaskBuru taskBuru)
        {
            await taskBuruCollection.InsertOneAsync(taskBuru);
        }

        public async Task UpdateTaskBuru(ModelTaskBuru taskBuru)
        {
            var filterTaskburu = Builders<ModelTaskBuru>
                .Filter
                .Eq(taskBuruFilter => taskBuruFilter.Id, taskBuru.Id);
            await taskBuruCollection.ReplaceOneAsync(filterTaskburu, taskBuru); 
        }
    }
}
