namespace DPI_Trainer
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.close_Button = new System.Windows.Forms.PictureBox();
            this.missBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.close_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missBox)).BeginInit();
            this.SuspendLayout();
            // 
            // close_Button
            // 
            this.close_Button.Image = ((System.Drawing.Image)(resources.GetObject("close_Button.Image")));
            this.close_Button.Location = new System.Drawing.Point(585, 274);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(50, 25);
            this.close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.close_Button.TabIndex = 0;
            this.close_Button.TabStop = false;
            this.close_Button.Click += new System.EventHandler(this.hit);
            // 
            // missBox
            // 
            this.missBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("missBox.BackgroundImage")));
            this.missBox.Location = new System.Drawing.Point(-56, -37);
            this.missBox.Name = "missBox";
            this.missBox.Size = new System.Drawing.Size(1351, 739);
            this.missBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.missBox.TabIndex = 1;
            this.missBox.TabStop = false;
            this.missBox.Click += new System.EventHandler(this.miss);
            this.missBox.DoubleClick += new System.EventHandler(this.extra);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Misses: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Left: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hit: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.missBox);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainer";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close_Button;
        private System.Windows.Forms.PictureBox missBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}