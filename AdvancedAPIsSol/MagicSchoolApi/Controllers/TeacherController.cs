using MagicSchoolApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace MagicSchoolApi.Controllers
{
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTeacherById(int id)
        {
            try
            {
                return Ok(_teacherService.GetTeacherById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
