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
        bool addState = false;
        bool editState = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            addState = !addState;
            ClearFields();
            sInfo.Enabled = !sInfo.Enabled;
            listBox1.Enabled = false;
            Edit.Enabled = false;
            Remove.Enabled = false;
            Add.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedStudent = (Student)listBox1.SelectedItem;

                FirstName = selectedStudent.FirstName;
                LastName = selectedStudent.LastName;
                Group = selectedStudent.Group;
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

        private void Remove_Click(object sender, EventArgs e)
        {
            controller.RemoveStudent();
            UpdateStudentInfo();
        }

        public Student SelectedStudent()
        {
            return (Student)listBox1.SelectedItem;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (addState)
            {
                listBox1.Enabled = true;
                controller.AddStudent();
                ClearFields();
                addState = false;
                if (listBox1.SelectedIndex != -1)
                {
                    Edit.Enabled = true;
                    Remove.Enabled = true;
                }
            }
            else if (editState)
            {
                listBox1.Enabled = true;
                controller.UpdateStudent();
                if (listBox1.SelectedIndex != -1)
                {
                    Edit.Enabled = true;
                    Remove.Enabled = true;
                    sInfo.Enabled = false;
                   
                }
                listBox1.Update();
            }
            Add.Enabled = true;
        }

        void ClearFields()
        {
            FirstName = "";
            LastName = "";
            Group = "";
            sInfo.Enabled = false;
        }


        void UpdateStudentInfo()
        {
            if(listBox1.SelectedIndex == -1)
            {
                FirstName = "";
                LastName = "";
                Group = "";
            }
            else
            {
                var selStud = (Student)listBox1.SelectedItem;
                FirstName = selStud.FirstName;
                LastName = selStud.LastName;
                Group = selStud.Group;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            editState = !editState;
            sInfo.Enabled = !sInfo.Enabled;
            listBox1.Enabled = false;
            Edit.Enabled = false;
            Remove.Enabled = false;
            Add.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateStudentInfo();
            if (listBox1.SelectedIndex != -1)
            {
                Edit.Enabled = true;
                Remove.Enabled = true;
                sInfo.Enabled = false;

            }
        
            Add.Enabled = true;
            editState = addState = false;
        }
    }
}
