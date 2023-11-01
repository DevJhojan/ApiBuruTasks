
using Microsoft.AspNetCore.Mvc;
using TaskBuru.Applications.Collections.CollectionTaskSiple;
using TaskBuru.Applications.Interfaces.ITaskSimple;
using TaskBuru.Domain.Models.TaskSimple;

namespace ApiBuruTasks.Controllers.ControllersTaskSimples
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : Controller
    {
        private ITaskBuruRepositoryCollection taskDataBaseRespository
            = new TaskBuruRepositoryCollection();
        [HttpGet]
        public async Task<IActionResult> GetAllTaskBuru()
        {
            return Ok(await taskDataBaseRespository.GetAllTaskBuru());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskBuruDetail(string id)
        {
            return Ok(await taskDataBaseRespository.GetTaskBuruById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreatedTaskBuru([FromBody] TaskBuruModel taskBuru)
        {
            if (taskBuru == null) return BadRequest();
            if (taskBuru.TitleTask == string.Empty)
                ModelState.AddModelError("TitleTask", "The propierty TitleTask is Empty");
            await taskDataBaseRespository.InsertTaskBuru(taskBuru);
            return Created("Created", taskBuru); 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTaskBuru([FromBody] TaskBuruModel taskBuru, string id)
        {
            if(taskBuru == null) return BadRequest();
            if (taskBuru.TitleTask == string.Empty)
                ModelState.AddModelError("TitleTask", "The propierty TitleTask is Empty");

            taskBuru.Id = new MongoDB.Bson.ObjectId(id);

            await taskDataBaseRespository.UpdateTaskBuru(taskBuru);
            return Created("Created", taskBuru);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletedTaskBuru(string id)
        {
            await taskDataBaseRespository.DeleteTaskBuru(id);
            return NoContent();
        }
    }
}
