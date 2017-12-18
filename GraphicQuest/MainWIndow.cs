using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicQuest
{
    public partial class MainWIndow : Form
    {

        BindingList<Quest> quests;
        Form1 rating;
        public MainWIndow()
        {
            InitializeComponent();
            InitLst();
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = quests;
            rating = new Form1(quests);
            rating.Visible = false;

            rating.FormClosing += rating_FormClosing;
        }

        void rating_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowRating.Checked = false;
            e.Cancel = true;
            Print.Enabled = false;
        }

        private void ShowRating_CheckedChanged(object sender, EventArgs e)
        {
            rating.Visible = ShowRating.Checked;
            Print.Enabled = rating.Visible;
        }

        private void add_Click(object sender, EventArgs e)
        {
            float  rate;
            if (float.TryParse(ratingBox.Text, out rate) && rate <= 5 && rate >= 0)
            {
               quests.Add(new Quest{
                    Name = nameBox.Text,
                    Rating = rate
                }
            );

             rating.Invalidate();
            }
            


        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            quests.Remove((Quest)listBox1.SelectedItem);
            rating.Invalidate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                delete.Enabled = true;
            }
            else delete.Enabled = false;
        }

        private void InitLst()
        {
            quests = new BindingList<Quest>()
            {
                new Quest()
                {
                    Name = "Umbrella",
                    Rating = 3.7f
                },
                new Quest()
                {
                    Name = "ZombeeAp",
                    Rating = 5f
                },
                new Quest()
                {
                    Name = "Ekzamen y Barabasha",
                    Rating = 1.1f
                },
                new Quest()
                {
                    Name = "Walking Dead",
                    Rating = 3.5f
                },
                new Quest()
                {
                    Name = "Harry potter",
                    Rating = 4.7f
                },
                new Quest()
                {
                    Name = "Programmer",
                    Rating = 0.4f
                },
                new Quest()
                {
                    Name = "Hobbit",
                    Rating = 2.9f
                },
                new Quest()
                {
                    Name = "Real life",
                    Rating = 0.2f
                }
            };
        }

      
        private void ratingBox_Validating(object sender, CancelEventArgs e)
        {
            float f = 0;
            bool res = float.TryParse(ratingBox.Text,out f);
            if (res == true)
            {
                add.Enabled = true;
            }
            else
            {
                add.Enabled = false;
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            rating.Print();
        }
    }
}
