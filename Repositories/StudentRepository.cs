using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWeb.Models;

namespace MyWeb.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>
        {
            new Student {StudentId = 1, Name = "Natalia", Email = "Nata@gmail,com", BirthDate = new DateOnly (2002,10,5) },
            new Student {StudentId = 2, Name = "Arrendele", Email = "Arre@gmail,com", BirthDate = new DateOnly (2000,3,8) },
            new Student {StudentId = 3, Name = "Dewa", Email = "Dewa@gmail,com", BirthDate = new DateOnly (1999,4,15) },
            new Student {StudentId = 4, Name = "Renn", Email = "Renn@gmail,com", BirthDate = new DateOnly (2001,9,12)}
        };
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }
        public Student GetById(int id)
        {
            return _students.First(s => s.StudentId == id);
        }
    }
}