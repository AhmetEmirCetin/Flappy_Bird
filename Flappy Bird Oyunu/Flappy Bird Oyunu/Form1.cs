using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Oyunu
{
    public partial class Form1 : Form
    {
        int boru_hızı = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            Boru_Alt.Left -= boru_hızı;
            Boru_Ust.Left -= boru_hızı;
            ScoreText.Text = "Score: " + score;
            if(Boru_Alt.Left<-150)
            {
                Boru_Alt.Left = 800;
                score++;
            }
            if (Boru_Ust.Left < -180)
            {
                Boru_Ust.Left = 950;
                score++;
            }
            if (FlappyBird.Bounds.IntersectsWith(Boru_Alt.Bounds) || FlappyBird.Bounds.IntersectsWith(Boru_Ust.Bounds) || FlappyBird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endgame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endgame()
        {
            GameTimer.Stop();
            ScoreText.Text = "GAME OVER !!!!!!!";
        }
    }
}
