using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPI_Trainer
{
    public partial class Form2 : Form
    {
        int counter = 1;
        int score = 0;
        int timeLeft = 10;
        bool flag = false;
        Point point;
        
        int newWidth, newHeight;
        Random rand = new Random();

        public Form2()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void hit(object sender, EventArgs e)
        {
            timeLeft = 10;
            flag = true;
            while (flag == true)
            {
                flag = false;
                moveCloseButton(sender, e);
                score += 1;
            }
            label3.Text = "Hit: " + score.ToString();
        }
        private void miss(object sender, EventArgs e)
        {
            label1.Text = "Misses: " + counter.ToString();
            counter += 1;
            if (counter > 3)
            {
                System.Windows.Forms.MessageBox.Show("You score:" + score.ToString(), "The End");
                timeLeft = 0;

                this.Hide();
                this.Close();

            }

        }

        public void moveCloseButton(object sender, EventArgs e)
        {
            int newPoint1 = rand.Next(10, this.ClientSize.Width - 50);
            int newPoint2 = rand.Next(10, this.ClientSize.Height - 25);
            close_Button.Location = new Point(newPoint1, newPoint2);

        }

        private void extra(object sender, EventArgs e)
        {
            counter += 1;
        }
        private bool check()
        {
            timer1.Start();

            if (newWidth != 0 || newHeight != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void timer1_Tick(object sender,EventArgs e)
        {
            newWidth = 50;
            newHeight = 25;

            if (check() || counter == 3)
            {
                timer1.Stop();
                miss(sender, e);
            }

            else if (timeLeft > 0 && score < 10)
            {

                timeLeft = timeLeft - 1;
                newWidth = newWidth - (10-timeLeft);
                newHeight = newHeight - (10 - timeLeft);
                close_Button.Size = new Size(newWidth, newHeight);
                //int temp_X = close_Button.Location.X + 1;
                //int temp_Y = close_Button.Location.Y;
                //close_Button.Location = new Point(temp_X, temp_Y);

                if (newHeight == 0 || timeLeft == 0)
                {
                    miss(sender, e);
                    moveCloseButton(sender, e);
                    timeLeft = 10;
                    newWidth = 50;
                    newHeight = 25;
                }

                label2.Text = "Time: " + timeLeft;

            }
            else if (timeLeft > 0 && score >= 10  && score <= 19)
            {
                timeLeft = timeLeft - 2;
                newWidth = newWidth - (10 - timeLeft);
                newHeight = newHeight - (10 - timeLeft);
                close_Button.Size = new Size(newWidth, newHeight);
                //int temp_X = close_Button.Location.X + 1;
                //int temp_Y = close_Button.Location.Y;
                //close_Button.Location = new Point(temp_X, temp_Y);

                if (newHeight <= 0 || timeLeft <= 0)
                {
                    miss(sender, e);
                    moveCloseButton(sender, e);
                    timeLeft = 10;
                    newWidth = 50;
                    newHeight = 25;
                }
                label2.Text = "Time: " + timeLeft;
            }
            else if (timeLeft > 0 && score >= 20)
            {
                timeLeft = timeLeft - 3;
                newWidth = newWidth - (10 - timeLeft);
                newHeight = newHeight - (10 - timeLeft);
                close_Button.Size = new Size(newWidth, newHeight);
                //int temp_X = close_Button.Location.X + 1;
                //int temp_Y = close_Button.Location.Y;
                //close_Button.Location = new Point(temp_X, temp_Y);

                if (newHeight <= 0 || timeLeft <= 0)
                {
                    miss(sender, e);
                    moveCloseButton(sender, e);
                    timeLeft = 10;
                    newWidth = 50;
                    newHeight = 25;
                }
                label2.Text = "Time: " + timeLeft;
            }
            else
            {
                timeLeft = timeLeft - 5;
                newWidth = newWidth - (10 - timeLeft);
                newHeight = newHeight - (10 - timeLeft);
                close_Button.Size = new Size(newWidth, newHeight);
                //int temp_X = close_Button.Location.X + 1;
                //int temp_Y = close_Button.Location.Y;
                //close_Button.Location = new Point(temp_X, temp_Y);

                if (newHeight <= 0 || timeLeft <= 0)
                {
                    miss(sender, e);
                    moveCloseButton(sender, e);
                    timeLeft = 10;
                    newWidth = 50;
                    newHeight = 25;
                }
                label2.Text = "Time: " + timeLeft;
            }
        }

    }
}

