using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Controllers;
using MVC.Models;


namespace MVC.Views
{
    public partial class StudentWindow : Form, IStudentInfoView
    {
        IStudentInfoController _controller;
        public StudentWindow(Student stud)
        {
            InitializeComponent();
            _controller = new StudentInfoController(this,stud);
        }

        public string FirstName
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }

        public string Group
        {
            get
            {
                return textBox3.Text;
            }
            set
            {
                textBox3.Text = value;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            _controller.FirstName_Validating(sender, e);
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            _controller.LastName_Validating(sender, e);
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            _controller.Group_Validating(sender, e);
        }
    }
}
