using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace GraphicQuest
{

   
    public partial class Form1 : Form
    {
        float heigth, width, top, left, bottom, rigth;
        List<Quest> quests;
        Bitmap img;
        public Form1()
        {
            InitializeComponent();
            img = new Bitmap(Width, Height);
            quests = new List<Quest>()
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
            Form1_Resize(null, null);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            using (var graphic = e.Graphics)
            {
                Pen linePen = new Pen(Color.Black, 2f);
                Computed();
                graphic.DrawLine(linePen, left, top, left, bottom);
                graphic.DrawLine(linePen, left - 1, bottom, rigth, bottom);

                for (int i = 0; i < 6; i++)
                {
                   var tmp = bottom - ((heigth / 5) * i);

                    graphic.DrawLine(linePen,left - 5, tmp, left + 5, tmp);
                    graphic.DrawString(i.ToString(), new Font("Arial", 10), Brushes.Black, left - 20, tmp - 7);
                }

                float widthTower = width / quests.Count;
                widthTower -= 10;
                if (widthTower > 50)
                {
                    widthTower = 50;
                }

                if (widthTower < 25)
                {
                    widthTower = 25;
                }

                int count;

                if (((width / widthTower) - 0.5) < quests.Count)
                {
                    count = (int)((width / widthTower) - 0.5);
                }
                else count = quests.Count;

                for (int i = 0; i < count; i++)
                {
                    float hPers = quests[i].Rating * 20;

                    float TowerHeigth = heigth * (hPers / 100);
                  
                    Brush b;
                    if (i % 2 == 0)
                        b = Brushes.Aqua;
                    else b = Brushes.Blue;

                    graphic.FillRectangle(b,10 + left + i * widthTower, bottom - TowerHeigth + 5, widthTower, TowerHeigth - 6);

                    graphic.RotateTransform(90);
                    graphic.DrawString(quests[i].Name, new Font("Arial", 10), Brushes.Black, 100, 100 );
                    graphic.ResetTransform();
                }

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Computed()
        {
            top = ClientSize.Height / 10;
            bottom = ClientSize.Height - top - top;
            left = ClientSize.Width / 14;
            rigth = ClientSize.Width - left;
            heigth = ClientSize.Height - top - top - top;
            width = ClientSize.Width - left - left;
        }
    }
}
