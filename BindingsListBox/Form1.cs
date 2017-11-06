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
        delegate void OKMode();
        OKMode OKModeFunc;
        BindingList<Film> films = new BindingList<Film>();
        public Form1()
        {
            InitializeComponent();
            BoxFilms.DataSource = films;
            for (int i = 1920; i < 2018; i++)
            {
                FilmYear.Items.Add(i);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Del.Enabled = false;
            Edit.Enabled = false;
            FilmInfo.Enabled = true;
            OKModeFunc = OKAdd;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilmInfo.Enabled = false;
            Add.Enabled = true;
            FilmDescr.Text = "";
            FilmName.Text = "";
            FilmYear.SelectedIndex = -1;
            if(BoxFilms.SelectedIndex != -1)
            {
                Edit.Enabled = true;
                Del.Enabled = true;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OKModeFunc();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            int index = BoxFilms.SelectedIndex;
            films.Remove(films[index]);
            button4_Click(sender, e);
            if(BoxFilms.SelectedIndex != -1)
            {
                Del.Enabled = true;
                Edit.Enabled = true;
            }
            else
            {
                Del.Enabled = false;
                Edit.Enabled = false;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            OKModeFunc = OKEdit;
            Add.Enabled = false;
            Del.Enabled = false;
            Edit.Enabled = false;
            FilmInfo.Enabled = true;

            int index = BoxFilms.SelectedIndex;

            FilmDescr.Text = films[index].Description;
            FilmName.Text = films[index].Name;
            FilmYear.SelectedItem = films[index].Year;
            
        }

        void OKAdd()
        {
            Film film = new Film();
            film.Description = FilmDescr.Text;
            film.Name = FilmName.Text;
            film.Year = int.Parse(FilmYear.Text);
            films.Add(film);
            button4_Click(null, null);
            Del.Enabled = true;
            Edit.Enabled = true;
        }

        void OKEdit()
        {
            Film film = new Film();
            film.Description = FilmDescr.Text;
            film.Name = FilmName.Text;
            film.Year = int.Parse(FilmYear.Text);
            films[BoxFilms.SelectedIndex] = film;
            button4_Click(null, null);
            Del.Enabled = true;
            Edit.Enabled = true;
        }


    }
}
