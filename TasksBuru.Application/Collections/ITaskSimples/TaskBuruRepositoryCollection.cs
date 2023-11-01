using TaskBuru.Applications.Interfaces.ITaskSimple;
using TaskBuru.Applications.Repositories.RepositoriesSimple;
using MongoDB.Bson;
using MongoDB.Driver;
using TaskBuru.Domain.Models.TaskSimple;

namespace TaskBuru.Applications.Collections.CollectionTaskSiple
{
    public class TaskBuruRepositoryCollection : ITaskBuruRepositoryCollection
    {
        internal TaskDataBaseRepository _taskRepository = new TaskDataBaseRepository();
        private IMongoCollection<TaskBuruModel> taskBuruCollection;

        public TaskBuruRepositoryCollection()
        {
            taskBuruCollection = _taskRepository.taskDataBase
                .GetCollection<TaskBuruModel>("TaskBuru");
        }

        public async Task DeleteTaskBuru(string id)
        {
            var filterTaskBuru = Builders<TaskBuruModel>
                .Filter.Eq(taskBuru => taskBuru.Id, new ObjectId(id));
            await taskBuruCollection.DeleteOneAsync(filterTaskBuru);
        }

        public async Task<List<TaskBuruModel>> GetAllTaskBuru()
        {
            return await taskBuruCollection
                .FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<TaskBuruModel> GetTaskBuruById(string id)
        {
            return await taskBuruCollection
                .FindAsync(new BsonDocument { { "_id", new ObjectId(id) } })
                .Result.FirstAsync();
        }

        public async Task InsertTaskBuru(TaskBuruModel taskBuru)
        {
            await taskBuruCollection.InsertOneAsync(taskBuru);
        }

        public async Task UpdateTaskBuru(TaskBuruModel taskBuru)
        {
            var filterTaskburu = Builders<TaskBuruModel>
                .Filter.Eq(taskBuruFilter => taskBuruFilter.Id, taskBuru.Id);
            await taskBuruCollection.ReplaceOneAsync(filterTaskburu, taskBuru); 
        }
    }
}
