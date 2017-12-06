using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    class Academy
    {
        List<Student> students = new List<Student>();
        int counter = 0;

        public void AddStudent(Student student)
        {
            counter++;
            student.Id = counter;
            students.Add(student);
        }

        public IEnumerable<Student> Students
        {
            get
            {
                return students;
            }
        }
    }
}
