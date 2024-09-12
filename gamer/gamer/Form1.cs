using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamer
{
    public partial class Form1 : Form
    {

        private Point pos;
        private bool cliked;
        private bool lose = false;
        private int CountCoin = 0;
        
        public Form1()
        {
            InitializeComponent();

            background.MouseDown += MouseClickDown;
            background.MouseUp += MouseClickUp;
            background.MouseMove += MouseClickMove;

            background1.MouseDown += MouseClickDown;
            background1.MouseUp += MouseClickUp;
            background1.MouseMove += MouseClickMove;

            LableLose.Visible = false;
            Restart.Visible = false;

            KeyPreview = true;
        }


        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            cliked = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            cliked = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if(cliked)
            {
                Point CurPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(CurPoint.X - pos.X, CurPoint.Y - pos.Y +background.Top);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 10;

            background.Top += speed;
            background1.Top += speed;

            Coin.Top += speed;

            if (background.Top > 650)
            {
                background.Top = 0;
                background1.Top = -650;
            }

            if (Coin.Top >= 650)
            {
                Coin.Top = -50;
                Random rand = new Random();
                Coin.Left = rand.Next(150,560);

            }

            int carspeed = 7;
            RedCar.Top += carspeed;
            RedCar1.Top += carspeed;
            if (RedCar.Top >= 650)
            {
                RedCar.Top = -130;
                Random rand = new Random();
                RedCar.Left = rand.Next(150, 300);
            }
            if (RedCar1.Top >= 650)
            {
                RedCar1.Top = -400;
                Random rand = new Random();
                RedCar1.Left = rand.Next(300, 560);
            }

            if ((Car.Bounds.IntersectsWith(RedCar.Bounds)) || (Car.Bounds.IntersectsWith(RedCar1.Bounds)))
            {
                timer1.Enabled = false;
                LableLose.Visible = true;
                Restart.Visible = true;
                lose = true;
            }

            if (Car.Bounds.IntersectsWith(Coin.Bounds))
            {
                ++CountCoin;
                LableCountCoin.Text = "Счет " + CountCoin.ToString();
                Coin.Top = -50;
                Random rand = new Random();
                Coin.Left = rand.Next(150, 560); // da da porabi funchiu dekat no mne pox govnokod
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose)  return;


            int speed = 10;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Car.Left > 150)
                Car.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Car.Right < 700)
                Car.Left += speed;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            RedCar.Top = -130;
            RedCar1.Top = -400;

            CountCoin = 0;
            LableCountCoin.Text = "Счет " + CountCoin.ToString();

            LableLose.Visible = false;
            Restart.Visible = false;
            lose = false;

            timer1.Enabled=true;


        }
    }
}
