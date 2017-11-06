using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingsListBox
{
    public partial class Form1 : Form
    {
        BindingList<Film> films = new BindingList<Film>();
        public Form1()
        {
            InitializeComponent();
            BoxFilms.DataSource = films;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Del.Enabled = false;
            Edit.Enabled = false;
            FilmInfo.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilmInfo.Enabled = false;
            Add.Enabled = true;
        }
    }
}
