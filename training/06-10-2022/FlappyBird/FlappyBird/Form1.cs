using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {


        int pipeSpeed = 8;
        int gravity = 7;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            pipeTop1.Left -= pipeSpeed;
            pipeBottom1.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            highScore.Text = score.ToString();

            if (pipeTop.Left < -20) 
            {
                pipeTop.Left = 750;
                pipeBottom.Left = 750;
                score++;
            }
            if (pipeTop1.Left < -20)
            {
                pipeTop1.Left = 750;
                pipeBottom1.Left = 750;
                score++;
            }
            if (pipeTop2.Left < -20)
            {
                pipeTop2.Left = 750;
                pipeBottom2.Left = 750;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || 
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || 
                flappyBird.Bounds.IntersectsWith(pipeBottom1.Bounds) || 
                flappyBird.Bounds.IntersectsWith(pipeTop1.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (score >= 101) 
            {
                winGame();
            }

            if (score > 10)
            {
                pipeSpeed = 10;
            }
            if (score > 20) 
            {
                pipeSpeed = 12;
            }
            if (score > 30)
            {
                pipeSpeed = 15;
            }
            if (score > 40)
            {
                pipeSpeed = 17;
            }
            if (score > 50)
            {
                pipeSpeed = 19;
            }
            if (score > 60)
            {
                pipeSpeed = 22;
            }
            if (score > 70)
            {
                pipeSpeed = 25;
            }
            if (score > 80)
            {
                pipeSpeed = 27;
            }
            if (score > 90)
            {
                pipeSpeed = 30;
            }

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
            {
                gravity = -8;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void endGame() 
        {
            gameTimer.Stop();
            highScore.Text += " pipes, Game Over!";
        }

        private void winGame()
        {
            gameTimer.Stop();
            highScore.Text += " pipes, You Win!";
        }
    }
}
