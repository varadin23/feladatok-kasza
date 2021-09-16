
namespace játék
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
            this.components = new System.ComponentModel.Container();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.pipedown2 = new System.Windows.Forms.PictureBox();
            this.scoreNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).BeginInit();
            this.SuspendLayout();
            // 
            // pipedown
            // 
            this.pipedown.Image = global::játék.Properties.Resources.pipedown;
            this.pipedown.Location = new System.Drawing.Point(571, -2);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(100, 170);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 0;
            this.pipedown.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::játék.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(129, 178);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(92, 80);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // pipe
            // 
            this.pipe.Image = global::játék.Properties.Resources.pipe;
            this.pipe.Location = new System.Drawing.Point(373, 329);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(100, 175);
            this.pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe.TabIndex = 2;
            this.pipe.TabStop = false;
            this.pipe.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ground
            // 
            this.ground.Image = global::játék.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-3, 500);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(786, 90);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(29, 23);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(83, 30);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score:";
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // pipedown2
            // 
            this.pipedown2.Image = global::játék.Properties.Resources.pipe;
            this.pipedown2.Location = new System.Drawing.Point(672, 329);
            this.pipedown2.Name = "pipedown2";
            this.pipedown2.Size = new System.Drawing.Size(100, 175);
            this.pipedown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown2.TabIndex = 5;
            this.pipedown2.TabStop = false;
            // 
            // scoreNumber
            // 
            this.scoreNumber.AutoSize = true;
            this.scoreNumber.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNumber.Location = new System.Drawing.Point(109, 23);
            this.scoreNumber.Name = "scoreNumber";
            this.scoreNumber.Size = new System.Drawing.Size(0, 30);
            this.scoreNumber.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(775, 585);
            this.Controls.Add(this.scoreNumber);
            this.Controls.Add(this.pipedown2);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe);
            this.Controls.Add(this.pipedown);
            this.Name = "Form1";
            this.Text = "Floppy Bird Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.PictureBox pipedown2;
        private System.Windows.Forms.Label scoreNumber;
    }
}

