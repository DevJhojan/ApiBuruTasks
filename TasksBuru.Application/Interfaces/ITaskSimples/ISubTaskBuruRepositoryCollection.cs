using TaskBuru.Domain.Models.TaskSimple;

namespace TaskBuru.Applications.Interfaces.ITaskSimple
{
    public interface ISubTaskBuruRepositoryCollection
    {
        Task InsertSubTaskBuru(SubTaskBuruModel subTaskBuru, string idTask);
        Task UpdateSubTaskBuru(SubTaskBuruModel subTaskBuru);
        Task DeleteSubTaskBuru(string id, string idTask);
        Task<List<SubTaskBuruModel>> GetAllSubTaskBuru();
        Task<SubTaskBuruModel> GetSubTaskBuruById(string id, string idTask);
    }
}
