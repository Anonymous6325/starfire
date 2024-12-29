using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class StarFire_Strike : Form
    {
        public StarFire_Strike()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            Restart.Hide();
        }

        bool right, left, space;
        int score;
        Queue<PictureBox> bullets = new Queue<PictureBox>();

        void Game_Result()
        {
            foreach (Control j in this.Controls)
            {
                foreach (Control i in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                i.Top = -100;
                                ((PictureBox)j).Image = Properties.Resource1.explosion;
                                score++;
                                lbl_score.Text = "Score : " + score;
                            }
                        }
                    }
                }
            }

            if (player.Bounds.IntersectsWith(ship.Bounds) || player.Bounds.IntersectsWith(alien.Bounds))
            {
                timer1.Stop();
                lbl_over.Show();
                lbl_score.BringToFront();
                Restart.Show();
            }
        }

        void star()
        {
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "star")
                {
                    j.Top += 10;
                    if (j.Top > this.Height)
                    {
                        j.Top = 0;
                    }
                }
            }
        }

        void Add_bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resource1.bullet_img;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + 35;
            bullet.Top = player.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();
            bullets.Enqueue(bullet);
        }

        void bullet_Movement()
        {
            int bulletCount = bullets.Count;
            for (int i = 0; i < bulletCount; i++)
            {
                PictureBox bullet = bullets.Dequeue();
                bullet.Top -= 10;
                if (bullet.Top < 100)
                {
                    this.Controls.Remove(bullet);
                }
                else
                {
                    bullets.Enqueue(bullet);
                }
            }
        }

        void Enemy_Movement()
        {
            Random rnd = new Random();
            int x, y;
            if (alien.Top > 500)
            {
                x = rnd.Next(0, this.Width - alien.Width);
                alien.Location = new Point(x, 0);
            }
            if (ship.Top >= 500)
            {
                y = rnd.Next(0, this.Width - ship.Width);
                ship.Location = new Point(y, 0);
            }
            else
            {
                alien.Top += 15;
                ship.Top += 10;
            }
        }

        void Arrow_key_Movement()
        {
            if (right == true)
            {
                if (player.Left < 425)
                {
                    player.Left += 20;
                }
            }
            if (left == true)
            {
                if (player.Left > 10)
                {
                    player.Left -= 20;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_bullet();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }

        void Timer1Tick(object sender, EventArgs e)
        {
            Arrow_key_Movement();
            Enemy_Movement();
            bullet_Movement();
            star();
            Game_Result();
        }

        void AlienClick(object sender, EventArgs e)
        {
        }

        private void StarFire_Strike_Load(object sender, EventArgs e)
        {
        }

        void Lbl_restartClick(object sender, EventArgs e)
        {
            timer1.Start();
            Restart.Hide();
            player.Location = new Point(195, 362);
            ship.Location = new Point(279, 0);
            alien.Location = new Point(25, 53);
            lbl_score.Text = "score : 0";
        }

        void Lbl_quitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
