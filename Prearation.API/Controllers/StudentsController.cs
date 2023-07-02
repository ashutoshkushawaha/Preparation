using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prearation.Domain.Dto;
using Prepration.Repository.Interfaces;

namespace Prearation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentServie;
        public StudentsController(IStudentService studentService) { 
        _studentServie = studentService;
        }
        [HttpPost]
        public async Task<bool> SaveStudent(StudentDto model)
        {
            return  await _studentServie.SaveStudent(model);
        }
    }
}
