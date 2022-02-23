namespace DPI_Trainer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.Welcome = new System.Windows.Forms.PictureBox();
            this.uselessButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Welcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uselessButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BackGround.Image = ((System.Drawing.Image)(resources.GetObject("BackGround.Image")));
            this.BackGround.Location = new System.Drawing.Point(-6, 2);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(1280, 720);
            this.BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGround.TabIndex = 1;
            this.BackGround.TabStop = false;
            this.BackGround.Click += new System.EventHandler(this.BackGround_Click);
            // 
            // Welcome
            // 
            this.Welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Image = ((System.Drawing.Image)(resources.GetObject("Welcome.Image")));
            this.Welcome.Location = new System.Drawing.Point(421, 65);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(465, 237);
            this.Welcome.TabIndex = 2;
            this.Welcome.TabStop = false;
            // 
            // uselessButton
            // 
            this.uselessButton.BackColor = System.Drawing.Color.Transparent;
            this.uselessButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.uselessButton.Image = ((System.Drawing.Image)(resources.GetObject("uselessButton.Image")));
            this.uselessButton.Location = new System.Drawing.Point(369, 343);
            this.uselessButton.Name = "uselessButton";
            this.uselessButton.Size = new System.Drawing.Size(557, 99);
            this.uselessButton.TabIndex = 3;
            this.uselessButton.TabStop = false;
            this.uselessButton.Click += new System.EventHandler(this.uselessButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.uselessButton);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.BackGround);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPI Trainer";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Welcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uselessButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.PictureBox Welcome;
        private System.Windows.Forms.PictureBox uselessButton;
    }
}

