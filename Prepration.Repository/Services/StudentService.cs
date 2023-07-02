using Prearation.Domain.Dto;
using Prearation.Domain.Models;
using Prepration.Repository.Interfaces;
using Presentation.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepration.Repository.Services
{
    public class StudentService : IStudentService
    {
        public readonly ApplicationDbContext _applicationDb;
        public StudentService(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }
        
        public async Task< bool> SaveStudent(StudentDto student)
        {
            try
            {
                var model = new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = student.Name,
                    Description = student.Description,
                    Email = student.Email,
                };
                _applicationDb.Students.Add(model);
                await _applicationDb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
           

        }
    }
}
