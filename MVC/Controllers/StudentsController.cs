using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    class StudentsController : IStudentsController
    {
        IStudentsView _view;
        public StudentsController(IStudentsView view)
        {
            _view = view;
        }

        Academy academy = new Academy();
        public IEnumerable<Student> GetStudents()
        {
            return academy.Students;
        }

        public void AddStudent()
        {

            var student = new Student
            {
                FirstName = _view.FirstName,
                LastName = _view.LastName,
                Group = _view.Group
            };

            academy.AddStudent(student);

            _view.AddStudentToList(student);
        }

        public void RemoveStudent()
        {
            academy.AddStudent(_view.SelectedStudent());
            _view.RemoveStudentFromList(_view.SelectedStudent());
        }

        public void UpdateStudent()
        {
            var SelStud = (Student)_view.SelectedStudent();
            SelStud.FirstName = _view.FirstName;
            SelStud.LastName = _view.LastName;
            SelStud.Group = _view.Group;
        }
    }
}
