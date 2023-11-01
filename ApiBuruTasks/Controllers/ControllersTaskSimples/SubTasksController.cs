
using Microsoft.AspNetCore.Mvc;
using TaskBuru.Applications.Collections.CollectionTaskSiple;
using TaskBuru.Applications.Interfaces.ITaskSimple;
using TaskBuru.Domain.Models.TaskSimple;

namespace ApiBuruTasks.Controllers.ControllersTaskSimples
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTasksController : Controller
    {
        private ISubTaskBuruRepositoryCollection SubTaskDataBaseRespository
            = new SubTaskBuruRepositoryCollection();

        private ITaskBuruRepositoryCollection taskDataBase = new TaskBuruRepositoryCollection();
        
        [HttpGet]
        public async Task<IActionResult> GetAllSubTaskBuru()
        {
            return Ok(await SubTaskDataBaseRespository.GetAllSubTaskBuru());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubTaskBuruDetail(string id, string idTask)
        {
            try
            {
                return Ok(await SubTaskDataBaseRespository.GetSubTaskBuruById(id, idTask));
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpPost("{idTask}")]
        public async Task<IActionResult> CreatedSubTaskBuru([FromBody] SubTaskBuruModel subTaskBuru, string idTask)
        {
            if (subTaskBuru == null) return BadRequest("El objeto subTaskBuru es nulo");
            if (subTaskBuru.TitleSubTask == string.Empty )
            {
                ModelState.AddModelError("TitleSubTask", "The propierty TitleSubTask is Empty");
                return BadRequest(ModelState);
            }

            try
            {
                subTaskBuru.IdTask = new MongoDB.Bson.ObjectId(idTask);
                
                await SubTaskDataBaseRespository.InsertSubTaskBuru(subTaskBuru, idTask);
                
                return Created("Created", subTaskBuru);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSubTaskBuru([FromBody] SubTaskBuruModel subTaskBuru, string id)
        {
            if (subTaskBuru == null) return BadRequest();
            if (subTaskBuru.TitleSubTask == string.Empty)
                ModelState.AddModelError("TitleTask", "The propierty TitleTask is Empty");
            try
            {
                subTaskBuru.Id = new MongoDB.Bson.ObjectId(id);
                await SubTaskDataBaseRespository.UpdateSubTaskBuru(subTaskBuru);
                return Created("Created", subTaskBuru);

            }
            catch(Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
            
        }

        [HttpDelete("{id}/{idTask}")]
        public async Task<IActionResult> DeletedSubTaskBuru(string id, string idTask)
        {
            try
            {
                var message = "Eliminado con Exito"; 
                await SubTaskDataBaseRespository.DeleteSubTaskBuru(id, idTask);
                return Ok(message);

            }
            catch(Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
    }
}
