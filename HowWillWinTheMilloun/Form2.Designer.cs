namespace HowWillWinTheMilloun
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
            this.lWinning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lWinning
            // 
            this.lWinning.AutoSize = true;
            this.lWinning.BackColor = System.Drawing.Color.Transparent;
            this.lWinning.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWinning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.lWinning.Location = new System.Drawing.Point(538, 403);
            this.lWinning.Name = "lWinning";
            this.lWinning.Size = new System.Drawing.Size(0, 69);
            this.lWinning.TabIndex = 0;
            // 
            // Form2
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HowWillWinTheMilloun.Properties.Resources.Congratulations_you_win;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.lWinning);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWinning;
    }
}