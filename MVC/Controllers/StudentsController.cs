using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class StudentsController : IStudentsController
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
            var newStudent = new Student();
            StudentWindow studInfoView = new StudentWindow(newStudent);
            
            if (studInfoView.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                academy.AddStudent(newStudent);
                _view.AddStudentToList(newStudent);
            }
        }

        public void RemoveStudent()
        {
            academy.AddStudent(_view.SelectedStudent());
            _view.RemoveStudentFromList(_view.SelectedStudent());
        }

        public void UpdateStudent()
        {
            var SelStud = (Student)_view.SelectedStudent();
            StudentWindow studInfoView = new StudentWindow(SelStud);
            if (studInfoView.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
