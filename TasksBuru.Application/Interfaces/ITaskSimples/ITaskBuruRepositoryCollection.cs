
using TaskBuru.Domain.Models.TaskSimple;

namespace TaskBuru.Applications.Interfaces.ITaskSimple
{
    public interface ITaskBuruRepositoryCollection
    {
        Task InsertTaskBuru(TaskBuruModel taskBuru);
        Task UpdateTaskBuru(TaskBuruModel taskBuru);
        Task DeleteTaskBuru(string id);
        Task<List<TaskBuruModel>> GetAllTaskBuru();
        Task<TaskBuruModel> GetTaskBuruById(string id);
    }
}
