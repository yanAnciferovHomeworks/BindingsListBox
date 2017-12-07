using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MVC.Models;
using MVC.Controllers;

namespace MVC.Views
{
    public partial class MainForm : Form, IStudentsView
    {
        IStudentsController controller;
        public MainForm()
        {
            InitializeComponent();

            controller = new StudentsController(this);

            listBox1.DisplayMember = "LastName";
            listBox1.ValueMember = "Id";
        }

        public void AddStudentToList(Student student)
        {
            listBox1.Items.Add(student);
        }

        public void ClearList()
        {
            listBox1.Items.Clear();
        }

        public void UpadateList(IEnumerable<Student> students)
        {
            listBox1.Items.Clear();
            foreach (Student st in students)
            {
                listBox1.Items.Add(st);
            }
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            controller.AddStudent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            controller.UpdateStudent();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            controller.RemoveStudent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedStudent = (Student)listBox1.SelectedItem;

                
                Remove.Enabled = true;
                Edit.Enabled = true;
            }
            else
            {
                Remove.Enabled = false;
                Edit.Enabled = false;
            }

        }

        public void RemoveStudentFromList(Student student)
        {
            listBox1.Items.Remove(student);
        }

       

        public Student SelectedStudent()
        {
            return (Student)listBox1.SelectedItem;
        }


      

     


       

        
    }
}
