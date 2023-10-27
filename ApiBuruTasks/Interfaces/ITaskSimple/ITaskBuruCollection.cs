using ApiBuruTasks.Models.TaskSimple;

namespace ApiBuruTasks.Interfaces.ITaskSimple
{
    public interface ITaskBuruCollection
    {
        Task InsertTaskBuru(ModelTaskBuru taskBuru);
        Task UpdateTaskBuru(ModelTaskBuru taskBuru);
        Task DeleteTaskBuru(string id);
        Task<List<ModelTaskBuru>> GetAllTaskBuru();
        Task<ModelTaskBuru> GetTaskBuruById(string id);
    }
}
