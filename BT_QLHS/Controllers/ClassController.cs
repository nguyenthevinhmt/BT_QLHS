using BT_QLHS.Models;
using BT_QLHS.Services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BT_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private IClass _classes;

        public ClassController(IClass classes)
        {
            _classes = classes;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var result = _classes.GetAll();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            try
            {
                var result = _classes.GetById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Create(Class cls)
        {
            try
            {
                _classes.Create(cls);
                return Ok("Them thanh cong!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Class cls)
        {
            try
            {
                _classes.Update(id, cls);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _classes.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddManyClassses")]
        public IActionResult CreateMany(List<Class> cls)
        {
            try
            {
                _classes.CreateListStudent(cls);
                return Ok("them thanh cong");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("getPage")]
        public IActionResult GetPage(int PageNumber, int PageSize)
        {
            try
            {
                var result = _classes.GetPage(PageNumber, PageSize);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
