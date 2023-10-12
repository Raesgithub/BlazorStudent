using BlazorStudent.Server.Data;
using BlazorStudent.Shared;
using BlazorStudent.Shared.Dtos;
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
        public ResultDto Post(Student student) {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return new ResultDto { isSuccess = true,message="Saved Successfully" };
            }
            catch (Exception ex)
            {
                ResultDto resultDto = new ResultDto();
                resultDto.isSuccess = false;
                resultDto.message = ex.InnerException == null ? ex.Message.Replace("'", "").Replace("\"", "") : ex.InnerException.Message.Replace("'", "").Replace("\"", "");
                return resultDto;
            }

        }
        [Route("Update")]
        [HttpPost]
        public ResultDto Update(Student student)
        {
            try
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return new ResultDto { isSuccess = true, message = "Saved Successfully" };
            }
            catch (Exception ex)
            {
                ResultDto resultDto = new ResultDto();
                resultDto.isSuccess = false;
                resultDto.message = ex.InnerException == null ? ex.Message.Replace("'", "").Replace("\"", "") : ex.InnerException.Message.Replace("'", "").Replace("\"", "");
                return resultDto;
            }
        }

    }
}
