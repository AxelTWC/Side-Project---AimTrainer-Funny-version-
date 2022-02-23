using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DPI_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Welcome.Parent = BackGround;
            uselessButton.Parent = BackGround;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Welcome.Parent = BackGround;
            uselessButton.Parent = BackGround;
        }

        private void BackGround_Click(object sender, EventArgs e)
        {
            Form2 Trainer = new Form2();
            this.Hide();
            Trainer.ShowDialog();
            Trainer.Show();
            this.Close(); 
        }

        private void uselessButton_Click(object sender, EventArgs e)
        {
            Form2 Trainer = new Form2();
            this.Hide();
            Trainer.ShowDialog();
            Trainer.Show();
            this.Close(); 
        }


    }
}
