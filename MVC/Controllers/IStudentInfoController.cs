using MVC.Models;
using MVC.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC.Controllers
{
    public interface IStudentInfoController
    {
        void FirstName_Validating(object sender, CancelEventArgs e);
        void LastName_Validating(object sender, CancelEventArgs e);
        void Group_Validating(object sender, CancelEventArgs e);

       
    }

    public class StudentInfoController : IStudentInfoController
    {
        Student _stud;
        IStudentInfoView _view;
        public StudentInfoController(IStudentInfoView view, Student stud)
        {
            _stud = stud;
            _view = view;
            view.FirstName = _stud.FirstName;
            view.LastName = _stud.LastName;
            view.Group = _stud.Group;
            
        }
        public void FirstName_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb.Text == "")
            {
                e.Cancel = true;
            }
            else
            {
                _stud.FirstName = tb.Text;
            }

        }

        public void LastName_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb.Text == "")
            {
                e.Cancel = true;
            }
            else
            {
                _stud.LastName = tb.Text;
            }
        }

        public void Group_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb.Text == "")
            {
                e.Cancel = true;
            }
            else
            {
                _stud.Group = tb.Text;
            }
        }

      
    }
}
