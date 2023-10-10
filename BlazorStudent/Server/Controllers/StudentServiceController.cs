using BlazorStudent.Server.Data;
using BlazorStudent.Shared;
using BlazorStudent.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorStudent.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentServiceController :ControllerBase
    {
        readonly DataContext _context;

        public StudentServiceController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.Students.ToList();   
        }
        [Route("Get/{id}")]
        [HttpGet]
        public Student Get(int id)
        {
            return _context.Students.Where(a=>a.Id==id).FirstOrDefault();
        }
        [HttpPost]
        public IActionResult Post(Student student) {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return Problem("sssssssssssssssssssssss");
            }
            
        }
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return Ok();
        }

    }
}
