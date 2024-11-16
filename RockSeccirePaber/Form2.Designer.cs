namespace RockSeccirePaber
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
            this.cbChoise = new Guna.UI2.WinForms.Guna2ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lUser = new System.Windows.Forms.Label();
            this.lComputer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResult = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChoise
            // 
            this.cbChoise.AutoRoundedCorners = true;
            this.cbChoise.BackColor = System.Drawing.Color.Transparent;
            this.cbChoise.BorderRadius = 17;
            this.cbChoise.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChoise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoise.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChoise.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChoise.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChoise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChoise.ItemHeight = 30;
            this.cbChoise.Items.AddRange(new object[] {
            "Rock",
            "Paper",
            "Scissors"});
            this.cbChoise.Location = new System.Drawing.Point(290, 39);
            this.cbChoise.Name = "cbChoise";
            this.cbChoise.Size = new System.Drawing.Size(231, 36);
            this.cbChoise.TabIndex = 0;
            this.cbChoise.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Screenshot 2024-07-04 010706.png");
            this.imageList1.Images.SetKeyName(1, "Screenshot 2024-07-04 010732.png");
            this.imageList1.Images.SetKeyName(2, "Screenshot 2024-07-04 010802.png");
            this.imageList1.Images.SetKeyName(3, "question-mark-96.png");
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(603, 130);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(36, 16);
            this.lUser.TabIndex = 2;
            this.lUser.Text = "User";
            // 
            // lComputer
            // 
            this.lComputer.AutoSize = true;
            this.lComputer.Location = new System.Drawing.Point(172, 130);
            this.lComputer.Name = "lComputer";
            this.lComputer.Size = new System.Drawing.Size(65, 16);
            this.lComputer.TabIndex = 4;
            this.lComputer.Text = "Computer";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(88, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnResult
            // 
            this.btnResult.AutoRoundedCorners = true;
            this.btnResult.BorderRadius = 28;
            this.btnResult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Location = new System.Drawing.Point(311, 359);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(188, 58);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "ShowResult";
            this.btnResult.Visible = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lComputer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbChoise);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbChoise;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label lComputer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnResult;
    }
}