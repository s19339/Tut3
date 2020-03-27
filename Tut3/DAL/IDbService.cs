using System.Collections;
using System.Collections.Generic;
using Tut3.Models;

namespace Tut3.DAL
{
 public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}