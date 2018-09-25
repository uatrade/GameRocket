using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRoket
{
    public partial class GameRocket : Form
    {
        delegate void AsterDel();

        static Random rnd;
        bool check;

        System.Threading.Timer TTimer1;
        System.Threading.Timer TTimer2;
        System.Threading.Timer TTimer3;
        System.Threading.Timer TTimer4;
        System.Threading.Timer TTimer5;
        System.Threading.Timer TTimer6;

        System.Threading.Timer TTimerCheck;


        Point first, second, third, forth, fifth, sixth, seven, eight;

        int conner;

        Task[] tasks = new Task[6];


        public GameRocket()
        {
            InitializeComponent();

            first.X = 50;

            eight.X = 110;
            eight.Y = 110;

            pictureBox8.SendToBack();

            pictureBox1.Image = new Bitmap(Properties.Resources.Asteroid);
            pictureBox1.Location = first;

            second.X = 200;
            pictureBox2.Image = new Bitmap(Properties.Resources.Asteroid);
            pictureBox2.Location = second;

            third.X = 350;
            pictureBox3.Image = new Bitmap(Properties.Resources.Asteroid);
            pictureBox3.Location = third;

            forth.X = 500;
            pictureBox4.Image = new Bitmap(Properties.Resources.Asteroid);
            pictureBox4.Location = forth;

            fifth.X = 620;
            pictureBox5.Image = new Bitmap(Properties.Resources.Asteroid);
            pictureBox5.Location = fifth;

            sixth.X = 730;
            pictureBox6.Image = new Bitmap(Properties.Resources.Asteroid);
            pictureBox6.Location = sixth;

            seven.Y = 350;
            seven.X = 400;
            pictureBox7.Image = new Bitmap(Properties.Resources.rocket);
            pictureBox7.Location = seven;


            pictureBox7.SendToBack();
            rnd = new Random();

            this.KeyDown += GameRocket_KeyDown;
            this.KeyPreview = true;

        }

        private void GameRocket_KeyDown(object sender, KeyEventArgs e)
        {

            Task task = new Task(() =>
            {
                if (e.KeyCode == Keys.A)
                {
                    if(seven.X>0)
                    seven.X -= 5;
                    pictureBox7.Location = seven;
                }
                if (e.KeyCode == Keys.D)
                {
                    if (seven.X < 750)
                        seven.X += 5;
                    pictureBox7.Location = seven;
                }
            }

            );

            task.Start();
        }

        void TimerCheck(object obj)
        {
            if (pictureBox7.Location.X >= pictureBox1.Location.X && pictureBox7.Location.X <= pictureBox1.Location.X + 40&&pictureBox1.Location.Y > 350|| pictureBox7.Location.X >= pictureBox2.Location.X && pictureBox7.Location.X <= pictureBox2.Location.X + 40 && pictureBox2.Location.Y > 350|| pictureBox7.Location.X >= pictureBox3.Location.X && pictureBox7.Location.X <= pictureBox3.Location.X + 40 && pictureBox3.Location.Y > 350|| pictureBox7.Location.X >= pictureBox4.Location.X && pictureBox7.Location.X <= pictureBox4.Location.X + 40 && pictureBox4.Location.Y > 350|| pictureBox7.Location.X >= pictureBox5.Location.X && pictureBox7.Location.X <= pictureBox5.Location.X + 40 && pictureBox5.Location.Y > 350|| pictureBox7.Location.X >= pictureBox6.Location.X && pictureBox7.Location.X <= pictureBox6.Location.X + 40 && pictureBox6.Location.Y > 350)
            {
                if (!check)
                {
                    TimerStop();
                    pictureBox7.Image = new Bitmap(Properties.Resources.rocket1);

                    check = true;
                }
            }

        }

        void TimerStop()
        {
            TTimerCheck.Change(Timeout.Infinite, 0);
            TTimer1.Change(Timeout.Infinite, Timeout.Infinite);
            TTimer2.Change(Timeout.Infinite, Timeout.Infinite);
            TTimer3.Change(Timeout.Infinite, Timeout.Infinite);
            TTimer4.Change(Timeout.Infinite, Timeout.Infinite);
            TTimer5.Change(Timeout.Infinite, Timeout.Infinite);
            TTimer6.Change(Timeout.Infinite, Timeout.Infinite);
        }

        void TickTimer1(object obj)
        {
            Rockets1();       //TODO Task
            Rockets2();
            Rockets3();
            Rockets4();
            Rockets5();
            Rockets6();
        }
        void TickTimer2(object obj)
        {
            Rockets2();
        }
        void TickTimer3(object obj)
        {
            Rockets3();
        }
        void TickTimer4(object obj)
        {
            Rockets4();
        }
        void TickTimer5(object obj)
        {
            Rockets5();
        }
        void TickTimer6(object obj)
        {
            Rockets6();
        }

        public void Rockets1()
        {
            first.Y += 5;

            if (first.X < 810 && first.Y > 490)
                first.X = first.X + rnd.Next(10, 300);
            if (first.X > 810 && first.Y > 490)
                first.X = 10;

            if (first.Y > 490)
                first.Y = 10;

            pictureBox1.Location = first;

            if (conner == 0)
            {
                pictureBox1.Image = new Bitmap(Properties.Resources.Asteroid1);
                conner = 1;
            }
            else
            {
                pictureBox1.Image = new Bitmap(Properties.Resources.Asteroid);
                conner = 0;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TimerStop();
        }

        public void Rockets2()
        {
            second.Y += 5;
            if (second.X < 810&&second.Y>490)
                second.X = second.X + rnd.Next(10, 300);
            if (second.X > 810 && second.Y > 490)
                second.X = 10;

            if (second.Y > 490)
                second.Y = 10;

            pictureBox2.Location = second;

            if (conner == 0)
            {
                pictureBox2.Image = new Bitmap(Properties.Resources.Asteroid1);
                conner = 1;
            }
            else
            {
                pictureBox2.Image = new Bitmap(Properties.Resources.Asteroid);
                conner = 0;
            }
        }

        public void Rockets3()
        {
            third.Y += 5;
            if (third.X < 810 && third.Y > 490)
                third.X = third.X + rnd.Next(10, 300);
            if (third.X > 810 && third.Y > 490)
                third.X = 10;

            if (third.Y > 490)
                third.Y = 10;

            pictureBox3.Location = third;

            if (conner == 0)
            {
                pictureBox3.Image = new Bitmap(Properties.Resources.Asteroid1);
                conner = 1;
            }
            else
            {
                pictureBox3.Image = new Bitmap(Properties.Resources.Asteroid);
                conner = 0;
            }
        }

        public void Rockets4()
        {
            forth.Y += 5;
            if (forth.X < 810 && forth.Y > 490)
                forth.X = forth.X + rnd.Next(10, 300);
            if (forth.X > 810 && forth.Y > 490)
                forth.X = 10;

            if (forth.Y > 490)
                forth.Y = 10;

            pictureBox4.Location = forth;

            if (conner == 0)
            {
                pictureBox4.Image = new Bitmap(Properties.Resources.Asteroid1);
                conner = 1;
            }
            else
            {
                pictureBox4.Image = new Bitmap(Properties.Resources.Asteroid);
                conner = 0;
            }
        }

        public void Rockets5()
        {
            fifth.Y += 5;
            if (fifth.X < 810 && fifth.Y > 490)
                fifth.X = forth.X + rnd.Next(10, 300);
            if (fifth.X > 810 && fifth.Y > 490)
                fifth.X = 10;

            if (fifth.Y > 490)
                fifth.Y = 10;

            pictureBox5.Location = fifth;

            if (conner == 0)
            {
                pictureBox5.Image = new Bitmap(Properties.Resources.Asteroid1);
                conner = 1;
            }
            else
            {
                pictureBox5.Image = new Bitmap(Properties.Resources.Asteroid);
                conner = 0;
            }
        }

        public void Rockets6()
        {
            sixth.Y += 5;
            if (sixth.X < 810 && sixth.Y > 490)
                sixth.X = sixth.X + rnd.Next(10, 300);
            if (sixth.X > 810 && sixth.Y > 490)
                sixth.X = 10;

            if (sixth.Y > 490)
                sixth.Y = 10;

            pictureBox6.Location = sixth;

            if (conner == 0)
            {
                pictureBox6.Image = new Bitmap(Properties.Resources.Asteroid1);
                conner = 1;
            }
            else
            {
                pictureBox6.Image = new Bitmap(Properties.Resources.Asteroid);
                conner = 0;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            check = false;
            pictureBox7.Image = new Bitmap(Properties.Resources.rocket);
            TTimer1 = new System.Threading.Timer(new TimerCallback(TickTimer1), null, 500, 150);
            TTimer2 = new System.Threading.Timer(new TimerCallback(TickTimer2), null, 500, 100);
            TTimer3 = new System.Threading.Timer(new TimerCallback(TickTimer3), null, 500, 150);
            TTimer4 = new System.Threading.Timer(new TimerCallback(TickTimer4), null, 500, 130);
            TTimer5 = new System.Threading.Timer(new TimerCallback(TickTimer5), null, 500, 170);
            TTimer6 = new System.Threading.Timer(new TimerCallback(TickTimer6), null, 500, 200);

            TTimerCheck = new System.Threading.Timer(new TimerCallback(TimerCheck), null, 500, 200);
        }
    }
}
