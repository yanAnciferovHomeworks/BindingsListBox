using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVC.Models;

namespace MVC.Views
{
    public interface IStudentsView
    {
        void AddStudentToList(Student student);
        void RemoveStudentFromList(Student student);
        //void RemoveStudentFromList(Student student);

        Student SelectedStudent();

        void ClearList();
        void UpadateList(IEnumerable<Student> students);


    }

    public interface IStudentInfoView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Group { get; set; }
    }
}
