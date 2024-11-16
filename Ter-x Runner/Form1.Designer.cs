namespace Ter_x_Runner
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
            this.pi = new System.Windows.Forms.PictureBox();
            this.Runner = new System.Windows.Forms.PictureBox();
            this.Tree1 = new System.Windows.Forms.PictureBox();
            this.Tree2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lScore = new System.Windows.Forms.Label();
            this.Pirds = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Runner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pirds)).BeginInit();
            this.SuspendLayout();
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pi.Location = new System.Drawing.Point(0, 386);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(801, 66);
            this.pi.TabIndex = 0;
            this.pi.TabStop = false;
            // 
            // Runner
            // 
            this.Runner.Location = new System.Drawing.Point(100, 335);
            this.Runner.Name = "Runner";
            this.Runner.Size = new System.Drawing.Size(48, 50);
            this.Runner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Runner.TabIndex = 1;
            this.Runner.TabStop = false;
            this.Runner.Tag = "Runner";
            // 
            // Tree1
            // 
            this.Tree1.BackgroundImage = global::Ter_x_Runner.Properties.Resources.obstacle_1;
            this.Tree1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tree1.Location = new System.Drawing.Point(473, 348);
            this.Tree1.Name = "Tree1";
            this.Tree1.Size = new System.Drawing.Size(26, 37);
            this.Tree1.TabIndex = 2;
            this.Tree1.TabStop = false;
            this.Tree1.Tag = "Tree";
            // 
            // Tree2
            // 
            this.Tree2.BackgroundImage = global::Ter_x_Runner.Properties.Resources.obstacle_2;
            this.Tree2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tree2.Enabled = false;
            this.Tree2.Location = new System.Drawing.Point(748, 352);
            this.Tree2.Name = "Tree2";
            this.Tree2.Size = new System.Drawing.Size(32, 33);
            this.Tree2.TabIndex = 3;
            this.Tree2.TabStop = false;
            this.Tree2.Tag = "Tree";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(15, 20);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(107, 30);
            this.lScore.TabIndex = 4;
            this.lScore.Text = "Score : 0";
            // 
            // Pirds
            // 
            this.Pirds.Location = new System.Drawing.Point(278, 236);
            this.Pirds.Name = "Pirds";
            this.Pirds.Size = new System.Drawing.Size(120, 70);
            this.Pirds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pirds.TabIndex = 5;
            this.Pirds.TabStop = false;
            this.Pirds.Tag = "Tree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 453);
            this.Controls.Add(this.Runner);
            this.Controls.Add(this.Pirds);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.Tree2);
            this.Controls.Add(this.Tree1);
            this.Controls.Add(this.pi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Runner_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Runner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pirds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pi;
        private System.Windows.Forms.PictureBox Runner;
        private System.Windows.Forms.PictureBox Tree1;
        private System.Windows.Forms.PictureBox Tree2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.PictureBox Pirds;
    }
}

