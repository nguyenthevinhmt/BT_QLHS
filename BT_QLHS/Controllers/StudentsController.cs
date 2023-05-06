using BT_QLHS.Models;
using BT_QLHS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BT_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //public IStudent _student;
        private IStudent _students;

        public StudentsController(IStudent students) {
            _students = students;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var result = _students.GetAll();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_students.GetById(id));
        }
        [HttpPost]
        public IActionResult Create(Student student) {
            try
            {
            _students.Create(student);
            return Ok("Them thanh cong!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Student student) {
            try
            {
                _students.Update(id, student);       
                return Ok();  

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _students.Delete(id);
            return Ok();
        }
    }
}
