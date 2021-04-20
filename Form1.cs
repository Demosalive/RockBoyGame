using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningGameCode
{
    public partial class SquareBoy : Form
    {
        int rockSpeed = 10;
        int gravity = 5;
        int score = 0;



        public SquareBoy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Hero.Top += gravity;
            Threat1.Left -= rockSpeed;
            threat2.Left -= rockSpeed;
            top1.Left -= rockSpeed;
            top2.Left -= rockSpeed;
            top3.Left -= rockSpeed;
            top4.Left -= rockSpeed;
            scoreText.Text = "Score: " + score;

            if (Threat1.Left < -150)
            {
                Threat1.Left = 800;
                score++;
            }
            if(threat2.Left < -180)
            {
                threat2.Left = 950;
                score++;
            }
            if (top1.Left < -120)
            {
                top1.Left = 800;
            }
            if (top2.Left < -120)
            {
                top2.Left = 800;
            }
            if (top3.Left < -120)
            {
                top3.Left = 800;
            }
            if (top4.Left < -120)
            {
                top4.Left = 800;
            }
            if (Hero.Bounds.IntersectsWith(floor.Bounds))
            {
                gravity = 0;
            }
            if (Hero.Bounds.IntersectsWith(Threat1.Bounds) || Hero.Bounds.IntersectsWith(threat2.Bounds) || Hero.Bounds.IntersectsWith(top1.Bounds)
                || Hero.Bounds.IntersectsWith(top2.Bounds) || Hero.Bounds.IntersectsWith(top3.Bounds) || Hero.Bounds.IntersectsWith(top4.Bounds))
            {
                endGame();
            }

            if (score>=3)
            {
                rockSpeed = 11;
            }
             if (score >=5 )
            {
                rockSpeed = 12;
            }
            if (score >= 7)
            {
                rockSpeed = 13;
            }
            if (score>=15)
            {
                rockSpeed = 20;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -8;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
           
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!!!";
        }

     
    }
}
