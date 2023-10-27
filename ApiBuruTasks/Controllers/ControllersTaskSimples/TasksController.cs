using ApiBuruTasks.Collections.CollectionTaskSiple;
using ApiBuruTasks.Interfaces.ITaskSimple;
using ApiBuruTasks.Models.TaskSimple;
using Microsoft.AspNetCore.Mvc;

namespace ApiBuruTasks.Controllers.ControllersTaskSimples
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : Controller
    {
        private ITaskBuruCollection taskDataBase = new TaskBuruCollection();

        [HttpGet]
        public async Task<IActionResult> GetAllTaskBuru()
        {
            return Ok(await taskDataBase.GetAllTaskBuru());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskBuruDetail(string id)
        {
            return Ok(await taskDataBase.GetTaskBuruById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreatedTaskBuru([FromBody] ModelTaskBuru taskBuru)
        {
            if (taskBuru == null) return BadRequest();
            if (taskBuru.TitleTask == string.Empty)
                ModelState.AddModelError("TitleTask", "The propierty TitleTask is Empty");
            await taskDataBase.InsertTaskBuru(taskBuru);
            return Created("Created", taskBuru); 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTaskBuru([FromBody] ModelTaskBuru taskBuru, string id)
        {
            if(taskBuru == null) return BadRequest();
            if (taskBuru.TitleTask == string.Empty)
                ModelState.AddModelError("TitleTask", "The propierty TitleTask is Empty");

            taskBuru.Id = new MongoDB.Bson.ObjectId(id);

            await taskDataBase.UpdateTaskBuru(taskBuru);
            return Created("Created", taskBuru);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletedTaskBuru(string id)
        {
            await taskDataBase.DeleteTaskBuru(id);
            return NoContent();
        }
    }
}
