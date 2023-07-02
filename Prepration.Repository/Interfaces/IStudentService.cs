using Prearation.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepration.Repository.Interfaces
{
    public interface IStudentService
    {
         Task<bool> SaveStudent(StudentDto student);

    }
}
