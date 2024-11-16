namespace TrixScoreRecordeer
{
    partial class frmCollaction
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
            this.lblSecondTeam = new System.Windows.Forms.Label();
            this.lblFirstTeam = new System.Windows.Forms.Label();
            this.guna2NumericUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSecondTeam
            // 
            this.lblSecondTeam.AutoSize = true;
            this.lblSecondTeam.Location = new System.Drawing.Point(609, 391);
            this.lblSecondTeam.Name = "lblSecondTeam";
            this.lblSecondTeam.Size = new System.Drawing.Size(44, 16);
            this.lblSecondTeam.TabIndex = 9;
            this.lblSecondTeam.Text = "label2";
            // 
            // lblFirstTeam
            // 
            this.lblFirstTeam.AutoSize = true;
            this.lblFirstTeam.Location = new System.Drawing.Point(147, 391);
            this.lblFirstTeam.Name = "lblFirstTeam";
            this.lblFirstTeam.Size = new System.Drawing.Size(44, 16);
            this.lblFirstTeam.TabIndex = 8;
            this.lblFirstTeam.Text = "label1";
            // 
            // guna2NumericUpDown2
            // 
            this.guna2NumericUpDown2.AutoRoundedCorners = true;
            this.guna2NumericUpDown2.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown2.BorderRadius = 23;
            this.guna2NumericUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown2.Location = new System.Drawing.Point(574, 316);
            this.guna2NumericUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2NumericUpDown2.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.guna2NumericUpDown2.Name = "guna2NumericUpDown2";
            this.guna2NumericUpDown2.Size = new System.Drawing.Size(114, 48);
            this.guna2NumericUpDown2.TabIndex = 7;
            this.guna2NumericUpDown2.ValueChanged += new System.EventHandler(this.guna2NumericUpDown2_ValueChanged);
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.AutoRoundedCorners = true;
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderRadius = 23;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(112, 316);
            this.guna2NumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2NumericUpDown1.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(114, 48);
            this.guna2NumericUpDown1.TabIndex = 6;
            this.guna2NumericUpDown1.ValueChanged += new System.EventHandler(this.guna2NumericUpDown2_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrixScoreRecordeer.Properties.Resources.icons8_cards_96;
            this.pictureBox1.Location = new System.Drawing.Point(342, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmCollaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecondTeam);
            this.Controls.Add(this.lblFirstTeam);
            this.Controls.Add(this.guna2NumericUpDown2);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCollaction";
            this.Text = "frmTrix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCollaction_FormClosing);
            this.Load += new System.EventHandler(this.frmCollaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecondTeam;
        private System.Windows.Forms.Label lblFirstTeam;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown2;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}