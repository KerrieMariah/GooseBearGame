using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveFauna(gamespeed);
            enemy(gamespeed + 1);
            gameover();
        }

        int gamespeed = 0; 

        void moveFauna(int speed)
        {

            if (bushes1.Top >= 500)
            {
                bushes1.Top = 0;
            }
            else
            {
                bushes1.Top += speed;
            }

            if (bushes2.Top >= 500)
            {
                bushes2.Top = 0;
            } else
            {
                bushes2.Top += speed;
            }

            if (bushes3.Top >= 500)
            {
                bushes3.Top = 0;
            }
            else
            {
                bushes3.Top += speed;
            }

            if (shrub1.Top >= 500)
            {
                shrub1.Top = 0;
            }
            else
            {
                shrub1.Top += speed;
            }

            if (shrub2.Top >= 500)
            {
                shrub2.Top = 0;
            }
            else
            {
                shrub2.Top += speed;
            }

            if (shrub3.Top >= 500)
            {
                shrub3.Top = 0;
            }
            else
            {
                shrub3.Top += speed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(goose.Left>0)
                {
                    goose.Left += -9;
                }
            }
            if(e.KeyCode==Keys.Right)
            {
                if(goose.Right<380)
                {
                    goose.Left += 9;
                }
            }

            if(e.KeyCode==Keys.Up)
            {
                if(gamespeed < 21)
                {
                    gamespeed++;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                if(gamespeed > 0)
                {
                    gamespeed--;
                }
            }
        }

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (bear1.Top >= 500)
            {
                x = r.Next(0, 380);
                bear1.Location = new Point(x, 0);
            }
            else
            {
                bear1.Top += speed;
            }

            if (bear2.Top >= 500)
            {
                x = r.Next(0, 380);
                bear2.Location = new Point(x, 0);
            }
            else
            {
                bear2.Top += speed;
            }

            if (bear3.Top >= 500)
            {
                x = r.Next(0, 380);
                bear3.Location = new Point(x, 0);
            }
            else
            {
                bear3.Top += speed;
            }
        }

        void gameover()
        {
            if(goose.Bounds.IntersectsWith(bear1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (goose.Bounds.IntersectsWith(bear2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (goose.Bounds.IntersectsWith(bear3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }
    }
}
