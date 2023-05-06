using BT_QLHS.Services.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BT_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassController : ControllerBase
    {
        private IStudentClass _studentClass;
        public StudentClassController(IStudentClass studentClass)
        {
            _studentClass = studentClass;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var result = _studentClass.getAll();
            return Ok(result);
        }
        [HttpGet("GetStudentByClassId")]
        public IActionResult getStudentsByClassID(int id)
        {
            var result = _studentClass.getStudentOfAClass(id);
            return Ok(result);
        }
        
    }
}
