using Serviceinterfacetask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serviceinterfacetask.Service
{
    public class TeacherService : IService<Teacher>
    {
        List<Teacher> _teacher = new List<Teacher>();
        public TeacherService()
        {
            for(int i=1;i<=9;i++)
            {
                _teacher.Add( new Teacher(){
                    TeacherId=i,
                    Name="Teacher"+i,
                    Subject="Sub"+i

                });
            }
        }
        public List<Teacher> Delete(int id)
        {
            _teacher.RemoveAll(x => x.TeacherId == id);
            return _teacher;
        }

        public List<Teacher> GetAll()
        {
            return _teacher;
        }

        public Teacher GetById(int id)
        {
            return _teacher.Where(x => x.TeacherId == id).SingleOrDefault();
        }

        public List<Teacher> Insert(Teacher item)
        {
            _teacher.Add(item);
            return _teacher;
        }

    }
}
