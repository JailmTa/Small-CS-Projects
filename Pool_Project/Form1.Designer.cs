namespace Pool_Project
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
            this.poolTable5 = new Pool_Project.PoolTable();
            this.poolTable6 = new Pool_Project.PoolTable();
            this.poolTable7 = new Pool_Project.PoolTable();
            this.poolTable8 = new Pool_Project.PoolTable();
            this.poolTable3 = new Pool_Project.PoolTable();
            this.poolTable4 = new Pool_Project.PoolTable();
            this.poolTable2 = new Pool_Project.PoolTable();
            this.poolTable1 = new Pool_Project.PoolTable();
            this.SuspendLayout();
            // 
            // poolTable5
            // 
            this.poolTable5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(233)))));
            this.poolTable5.CostForOneHourOfPlayingPB = 500F;
            this.poolTable5.CostForOneHourOfPlayingPS = 100F;
            this.poolTable5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.poolTable5.Location = new System.Drawing.Point(804, 292);
            this.poolTable5.Name = "poolTable5";
            this.poolTable5.PlayGame = Pool_Project.PoolTable.enPlayType.PlayStation;
            this.poolTable5.Size = new System.Drawing.Size(268, 286);
            this.poolTable5.TabIndex = 7;
            this.poolTable5.OnEndTimer += new System.Action<System.TimeSpan, float>(this.poolTable1_OnEndTimer);
            // 
            // poolTable6
            // 
            this.poolTable6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(233)))));
            this.poolTable6.CostForOneHourOfPlayingPB = 500F;
            this.poolTable6.CostForOneHourOfPlayingPS = 100F;
            this.poolTable6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.poolTable6.Location = new System.Drawing.Point(536, 292);
            this.poolTable6.Name = "poolTable6";
            this.poolTable6.PlayGame = Pool_Project.PoolTable.enPlayType.PlayStation;
            this.poolTable6.Size = new System.Drawing.Size(268, 286);
            this.poolTable6.TabIndex = 6;
            this.poolTable6.OnEndTimer += new System.Action<System.TimeSpan, float>(this.poolTable1_OnEndTimer);
            // 
            // poolTable7
            // 
            this.poolTable7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(233)))));
            this.poolTable7.CostForOneHourOfPlayingPB = 500F;
            this.poolTable7.CostForOneHourOfPlayingPS = 100F;
            this.poolTable7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.poolTable7.Location = new System.Drawing.Point(268, 292);
            this.poolTable7.Name = "poolTable7";
            this.poolTable7.PlayGame = Pool_Project.PoolTable.enPlayType.PlayStation;
            this.poolTable7.Size = new System.Drawing.Size(268, 286);
            this.poolTable7.TabIndex = 5;
            this.poolTable7.OnEndTimer += new System.Action<System.TimeSpan, float>(this.poolTable1_OnEndTimer);
            // 
            // poolTable8
            // 
            this.poolTable8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(233)))));
            this.poolTable8.CostForOneHourOfPlayingPB = 500F;
            this.poolTable8.CostForOneHourOfPlayingPS = 100F;
            this.poolTable8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.poolTable8.Location = new System.Drawing.Point(0, 292);
            this.poolTable8.Name = "poolTable8";
            this.poolTable8.PlayGame = Pool_Project.PoolTable.enPlayType.PlayStation;
            this.poolTable8.Size = new System.Drawing.Size(268, 286);
            this.poolTable8.TabIndex = 4;
            this.poolTable8.OnEndTimer += new System.Action<System.TimeSpan, float>(this.poolTable1_OnEndTimer);
            // 
            // poolTable3
            // 
            this.poolTable3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(233)))));
            this.poolTable3.CostForOneHourOfPlayingPB = 500F;
            this.poolTable3.CostForOneHourOfPlayingPS = 100F;
            this.poolTable3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.poolTable3.Location = new System.Drawing.Point(804, 0);
            this.poolTable3.Name = "poolTable3";
            this.poolTable3.PlayGame = Pool_Project.PoolTable.enPlayType.PoolBall;
            this.poolTable3.Size = new System.Drawing.Size(268, 286);
            this.poolTable3.TabIndex = 3;
            this.poolTable3.OnEndTimer += new System.Action<System.TimeSpan, float>(this.poolTable1_OnEndTimer);
            // 
            // poolTable4
            // 
            this.poolTable4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(233)))));
            this.poolTable4.CostForOneHourOfPlayingPB = 500F;
            this.poolTable4.CostForOneHourOfPlayingPS = 100F;
            this.poolTable4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.poolTable4.Location = new System.Drawing.Point(536, 0);
            this.poolTable4.Name = "poolTable4";
            this.poolTable4.PlayGame = Pool_Project.PoolTable.enPlayType.PoolBall;
            this.poolTable4.Size = new System.Drawing.Size(268, 286);
            this.poolTable4.TabIndex = 2;
            this.poolTable4.OnEndTimer += new System.Action<System.TimeSpan, float>(this.poolTable1_OnEndTimer);
            // 
            // poolTable2
            // 
            this.poolTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(233)))));
            this.poolTable2.CostForOneHourOfPlayingPB = 500F;
            this.poolTable2.CostForOneHourOfPlayingPS = 100F;
            this.poolTable2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.poolTable2.Location = new System.Drawing.Point(268, 0);
            this.poolTable2.Name = "poolTable2";
            this.poolTable2.PlayGame = Pool_Project.PoolTable.enPlayType.PoolBall;
            this.poolTable2.Size = new System.Drawing.Size(268, 286);
            this.poolTable2.TabIndex = 1;
            this.poolTable2.OnEndTimer += new System.Action<System.TimeSpan, float>(this.poolTable1_OnEndTimer);
            // 
            // poolTable1
            // 
            this.poolTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(233)))));
            this.poolTable1.CostForOneHourOfPlayingPB = 500F;
            this.poolTable1.CostForOneHourOfPlayingPS = 100F;
            this.poolTable1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.poolTable1.Location = new System.Drawing.Point(0, 0);
            this.poolTable1.Name = "poolTable1";
            this.poolTable1.PlayGame = Pool_Project.PoolTable.enPlayType.PoolBall;
            this.poolTable1.Size = new System.Drawing.Size(268, 286);
            this.poolTable1.TabIndex = 0;
            this.poolTable1.OnEndTimer += new System.Action<System.TimeSpan, float>(this.poolTable1_OnEndTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1073, 577);
            this.Controls.Add(this.poolTable5);
            this.Controls.Add(this.poolTable6);
            this.Controls.Add(this.poolTable7);
            this.Controls.Add(this.poolTable8);
            this.Controls.Add(this.poolTable3);
            this.Controls.Add(this.poolTable4);
            this.Controls.Add(this.poolTable2);
            this.Controls.Add(this.poolTable1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private PoolTable poolTable2;
        private PoolTable poolTable3;
        private PoolTable poolTable4;
        private PoolTable poolTable5;
        private PoolTable poolTable6;
        private PoolTable poolTable7;
        private PoolTable poolTable8;
        private PoolTable poolTable1;
    }
}

