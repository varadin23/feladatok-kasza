
namespace raktar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termekekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.termekekToolStripMenuItem,
            this.statisztikaToolStripMenuItem,
            this.statisztikaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.loginToolStripMenuItem.Text = "login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // termekekToolStripMenuItem
            // 
            this.termekekToolStripMenuItem.Name = "termekekToolStripMenuItem";
            this.termekekToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.termekekToolStripMenuItem.Text = "Termékek";
            this.termekekToolStripMenuItem.Click += new System.EventHandler(this.termekekToolStripMenuItem_Click);
            // 
            // statisztikaToolStripMenuItem
            // 
            this.statisztikaToolStripMenuItem.Name = "statisztikaToolStripMenuItem";
            this.statisztikaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.statisztikaToolStripMenuItem.Text = "Eladás";
            this.statisztikaToolStripMenuItem.Click += new System.EventHandler(this.statisztikaToolStripMenuItem_Click);
            // 
            // statisztikaToolStripMenuItem1
            // 
            this.statisztikaToolStripMenuItem1.Name = "statisztikaToolStripMenuItem1";
            this.statisztikaToolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.statisztikaToolStripMenuItem1.Text = "Statisztika";
            this.statisztikaToolStripMenuItem1.Click += new System.EventHandler(this.statisztikaToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termekekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisztikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisztikaToolStripMenuItem1;
    }
}

