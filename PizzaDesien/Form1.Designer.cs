namespace PizzaDesien
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSingUp = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(136, 468);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(141, 33);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.AutoRoundedCorners = true;
            this.tbUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbUserName.BorderColor = System.Drawing.Color.Tomato;
            this.tbUserName.BorderRadius = 16;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.Parent = this.tbUserName;
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.FocusedState.Parent = this.tbUserName;
            this.tbUserName.ForeColor = System.Drawing.Color.Black;
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.HoverState.Parent = this.tbUserName;
            this.tbUserName.Location = new System.Drawing.Point(126, 373);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.tbUserName.PlaceholderText = "";
            this.tbUserName.SelectedText = "";
            this.tbUserName.ShadowDecoration.Parent = this.tbUserName;
            this.tbUserName.Size = new System.Drawing.Size(232, 35);
            this.tbUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(2, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(2, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "PassWord";
            // 
            // tbPassWord
            // 
            this.tbPassWord.AutoRoundedCorners = true;
            this.tbPassWord.BackColor = System.Drawing.Color.Transparent;
            this.tbPassWord.BorderColor = System.Drawing.Color.Tomato;
            this.tbPassWord.BorderRadius = 16;
            this.tbPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassWord.DefaultText = "";
            this.tbPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassWord.DisabledState.Parent = this.tbPassWord;
            this.tbPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassWord.FocusedState.Parent = this.tbPassWord;
            this.tbPassWord.ForeColor = System.Drawing.Color.Black;
            this.tbPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassWord.HoverState.Parent = this.tbPassWord;
            this.tbPassWord.Location = new System.Drawing.Point(126, 421);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '\0';
            this.tbPassWord.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.tbPassWord.PlaceholderText = "";
            this.tbPassWord.SelectedText = "";
            this.tbPassWord.ShadowDecoration.Parent = this.tbPassWord;
            this.tbPassWord.Size = new System.Drawing.Size(232, 35);
            this.tbPassWord.TabIndex = 3;
            // 
            // btnSingUp
            // 
            this.btnSingUp.AutoRoundedCorners = true;
            this.btnSingUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSingUp.BorderRadius = 21;
            this.btnSingUp.CheckedState.Parent = this.btnSingUp;
            this.btnSingUp.CustomImages.Parent = this.btnSingUp;
            this.btnSingUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnSingUp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingUp.ForeColor = System.Drawing.Color.Black;
            this.btnSingUp.HoverState.Parent = this.btnSingUp;
            this.btnSingUp.Location = new System.Drawing.Point(294, 463);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.ShadowDecoration.Parent = this.btnSingUp;
            this.btnSingUp.Size = new System.Drawing.Size(64, 44);
            this.btnSingUp.TabIndex = 5;
            this.btnSingUp.Text = "SingUp";
            this.btnSingUp.Click += new System.EventHandler(this.btnSingUp_Click);
            // 
            // Form1
            // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaDesien.Properties.Resources.Its_Your_Pizza_Time_20240625_205210_0000;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.btnSingUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btnLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbPassWord;
        private Guna.UI2.WinForms.Guna2Button btnSingUp;
    }
}

