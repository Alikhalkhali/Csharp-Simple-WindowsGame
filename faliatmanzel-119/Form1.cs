using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faliatmanzel_119
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int score;   //Declare the "score" variable to store the score
        bool isStart = false; //Declare the "isStart" variable for the  user clicked the start button or not and the default value is flase
        private void cScore()  //Function to determine the user's score (whether it gets a positive score or a negative score)
        {
            if (lblAvatar.Bounds.IntersectsWith(lblScore1.Bounds) ||
                lblAvatar.Bounds.IntersectsWith(lblScore2.Bounds) ||
                lblAvatar.Bounds.IntersectsWith(lblScore3.Bounds) ||
                lblAvatar.Bounds.IntersectsWith(lblScore4.Bounds)) //If the avatar hits the red square, the score increases(+1)
            {
                MessageBox.Show("امتیاز شما اضافه شد!");
                score++;

            }
            if (lblAvatar.Bounds.IntersectsWith(lblNScore1.Bounds) ||
                lblAvatar.Bounds.IntersectsWith(lblNScore2.Bounds) ||
                lblAvatar.Bounds.IntersectsWith(lblNScore3.Bounds) ||
                lblAvatar.Bounds.IntersectsWith(lblNScore4.Bounds)) //If the avatar hits the pink square, the score decreases(-1)
            {
                MessageBox.Show("وای امتیاز شما کم شد!");
                score--;
            }
            if (lblAvatar.Bounds.IntersectsWith(lblCrab1.Bounds) ||
                lblAvatar.Bounds.IntersectsWith(lblCrab2.Bounds) ||
                lblAvatar.Bounds.IntersectsWith(lblCrab3.Bounds)) //If the avatar hits the crab, the score decreases(-2)
            {
                MessageBox.Show("امتیاز شما کم شد.مواظب خرچنگ ها باش!");
                score -= 2;

            }


        }
        private void wall(string move) //Wall function to determine if the user hit the wall or not. If so, it returns to its previous location.Takes an ergium to detect the direction of movement
        {
            if (lblAvatar.Bounds.IntersectsWith(lblWall1.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall2.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall3.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall4.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall5.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall6.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall7.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall8.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall9.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall10.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall11.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall12.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall13.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall14.Bounds) || lblAvatar.Bounds.IntersectsWith(lblWall15.Bounds))
            {
                switch (move)
                {
                    case "right":
                        {
                            lblAvatar.Left -= 10;
                            break;
                        }
                    case "left":
                        {
                            lblAvatar.Left += 10;
                            break;
                        }
                    case "up":
                        {
                            lblAvatar.Top += 10;
                            break;
                        }
                    case "down":
                        {
                            lblAvatar.Top -= 10;
                            break;
                        }


                }

            }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            score = 0; //The score value becomes zero
            MessageBox.Show("بازی شروع شد! بزن بریم...");
            isStart = true;     //If the user clicks on the start button, the  isStart variable be ture.
        }

        private void btnEnd_Click(object sender, EventArgs e) //if the user clicks on the end button ,a message is displayed displaying the user's score and the application is closed.
        {
            MessageBox.Show("امتیاز شما :" + score.ToString());
            this.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (isStart)   //check user clicks on the strat button or not
            {
                lblAvatar.Left += +10;
                cScore();
                wall("right");

            }
            else
            {

                MessageBox.Show("بازی رو هنوز شروع نکردی! روی دکمه شروع بزن.");
            }

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

            if (isStart) //check user clicks on the strat button or not
            {
                lblAvatar.Left -= 10;
                cScore();
                wall("left");

            }
            else // If not, it shows a message that you have to click the start button to start
            {

                MessageBox.Show("بازی رو هنوز شروع نکردی! روی دکمه شروع بزن.");
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

            if (isStart)//check user clicks on the strat button or not
            {
                lblAvatar.Top -= 10;
                cScore();
                wall("up");

            }
            else // If not, it shows a message that you have to click the start button to start
            {

                MessageBox.Show("بازی رو هنوز شروع نکردی! روی دکمه شروع بزن.");
            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (isStart)//check user clicks on the strat button 
            {
                lblAvatar.Top += 10;
                cScore();
                wall("down");

            }
            else // If not, it shows a message that you have to click the start button to start
            {
                MessageBox.Show("بازی رو هنوز شروع نکردی! روی دکمه شروع بزن.");
            }

        }


    }

}