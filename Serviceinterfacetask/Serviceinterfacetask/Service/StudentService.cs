using Serviceinterfacetask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serviceinterfacetask.Service
{
    public class StudentService : IService<Student>
       
    {
        List<Student> _student = new List<Student>();

        public StudentService()
        {
            for(int i=1;i<=9;i++)
            {
                _student.Add(new Student()
                {
                    StudentId = i,
                    Name = "Student" + i,
                    Roll = "200" + i
                });
            }
        }
        public List<Student> Delete(int id)
        {
            _student.RemoveAll(x => x.StudentId == id);
            return _student;
        }

        public List<Student> GetAll()
        {
            return _student;
        }

        public Student GetById(int id)
        {
            return _student.Where(x => x.StudentId == id).SingleOrDefault();
        }

        public List<Student> Insert(Student item)
        {
            _student.Add(item);
            return _student;
        }
    }
}
