using MongoDB.Driver;

namespace ApiBuruTasks.Repositories
{
    public class TaskDataBaseRepository
    {
        public MongoClient taskClient;
        public IMongoDatabase taskDataBase;

        public TaskDataBaseRepository()
        {
            taskClient = new MongoClient("mongodb://127.0.0.1:27017");
            taskDataBase = taskClient.GetDatabase("working-todo");
        }
    }
}
