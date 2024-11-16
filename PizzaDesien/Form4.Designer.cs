namespace PizzaDesien
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBIrthDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddreass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbConfermPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.llSetPic = new System.Windows.Forms.LinkLabel();
            this.tbPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSava = new Guna.UI2.WinForms.Guna2Button();
            this.btnCansel = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbProfilPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(274, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Custemar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name : ";
            // 
            // tbFirstName
            // 
            this.tbFirstName.AutoRoundedCorners = true;
            this.tbFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.tbFirstName.BorderRadius = 14;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.Parent = this.tbFirstName;
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.FocusedState.Parent = this.tbFirstName;
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.HoverState.Parent = this.tbFirstName;
            this.tbFirstName.Location = new System.Drawing.Point(135, 94);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PlaceholderText = "";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.ShadowDecoration.Parent = this.tbFirstName;
            this.tbFirstName.Size = new System.Drawing.Size(254, 31);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.PutErrorProvider);
            // 
            // tbLastName
            // 
            this.tbLastName.AutoRoundedCorners = true;
            this.tbLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.tbLastName.BorderRadius = 14;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.Parent = this.tbLastName;
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.FocusedState.Parent = this.tbLastName;
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.HoverState.Parent = this.tbLastName;
            this.tbLastName.Location = new System.Drawing.Point(135, 133);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.SelectedText = "";
            this.tbLastName.ShadowDecoration.Parent = this.tbLastName;
            this.tbLastName.Size = new System.Drawing.Size(254, 31);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.PutErrorProvider);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name :";
            // 
            // tbEmail
            // 
            this.tbEmail.AutoRoundedCorners = true;
            this.tbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.tbEmail.BorderRadius = 14;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.Parent = this.tbEmail;
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.Location = new System.Drawing.Point(135, 172);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(254, 31);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.PutErrorProvider);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email :";
            // 
            // dtpBIrthDate
            // 
            this.dtpBIrthDate.Location = new System.Drawing.Point(135, 269);
            this.dtpBIrthDate.Name = "dtpBIrthDate";
            this.dtpBIrthDate.Size = new System.Drawing.Size(254, 22);
            this.dtpBIrthDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "BirthDate : ";
            // 
            // tbAddreass
            // 
            this.tbAddreass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.tbAddreass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddreass.DefaultText = "";
            this.tbAddreass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAddreass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAddreass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddreass.DisabledState.Parent = this.tbAddreass;
            this.tbAddreass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddreass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddreass.FocusedState.Parent = this.tbAddreass;
            this.tbAddreass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddreass.HoverState.Parent = this.tbAddreass;
            this.tbAddreass.Location = new System.Drawing.Point(135, 308);
            this.tbAddreass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddreass.Multiline = true;
            this.tbAddreass.Name = "tbAddreass";
            this.tbAddreass.PasswordChar = '\0';
            this.tbAddreass.PlaceholderText = "";
            this.tbAddreass.SelectedText = "";
            this.tbAddreass.ShadowDecoration.Parent = this.tbAddreass;
            this.tbAddreass.Size = new System.Drawing.Size(254, 114);
            this.tbAddreass.TabIndex = 9;
            this.tbAddreass.Validating += new System.ComponentModel.CancelEventHandler(this.PutErrorProvider);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Addreass : ";
            // 
            // tbPassWord
            // 
            this.tbPassWord.AutoRoundedCorners = true;
            this.tbPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.tbPassWord.BorderRadius = 14;
            this.tbPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassWord.DefaultText = "";
            this.tbPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassWord.DisabledState.Parent = this.tbPassWord;
            this.tbPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassWord.FocusedState.Parent = this.tbPassWord;
            this.tbPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassWord.HoverState.Parent = this.tbPassWord;
            this.tbPassWord.Location = new System.Drawing.Point(533, 309);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '\0';
            this.tbPassWord.PlaceholderText = "";
            this.tbPassWord.SelectedText = "";
            this.tbPassWord.ShadowDecoration.Parent = this.tbPassWord;
            this.tbPassWord.Size = new System.Drawing.Size(254, 31);
            this.tbPassWord.TabIndex = 14;
            this.tbPassWord.Validating += new System.ComponentModel.CancelEventHandler(this.PutErrorProvider);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "PassWord :";
            // 
            // tbUserName
            // 
            this.tbUserName.AutoRoundedCorners = true;
            this.tbUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.tbUserName.BorderRadius = 14;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.Parent = this.tbUserName;
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.FocusedState.Parent = this.tbUserName;
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.HoverState.Parent = this.tbUserName;
            this.tbUserName.Location = new System.Drawing.Point(533, 270);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderText = "";
            this.tbUserName.SelectedText = "";
            this.tbUserName.ShadowDecoration.Parent = this.tbUserName;
            this.tbUserName.Size = new System.Drawing.Size(254, 31);
            this.tbUserName.TabIndex = 12;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.PutErrorProvider);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "User Name : ";
            // 
            // tbConfermPassWord
            // 
            this.tbConfermPassWord.AutoRoundedCorners = true;
            this.tbConfermPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.tbConfermPassWord.BorderRadius = 14;
            this.tbConfermPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfermPassWord.DefaultText = "";
            this.tbConfermPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfermPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfermPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfermPassWord.DisabledState.Parent = this.tbConfermPassWord;
            this.tbConfermPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfermPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfermPassWord.FocusedState.Parent = this.tbConfermPassWord;
            this.tbConfermPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfermPassWord.HoverState.Parent = this.tbConfermPassWord;
            this.tbConfermPassWord.Location = new System.Drawing.Point(533, 348);
            this.tbConfermPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfermPassWord.Name = "tbConfermPassWord";
            this.tbConfermPassWord.PasswordChar = '\0';
            this.tbConfermPassWord.PlaceholderText = "";
            this.tbConfermPassWord.SelectedText = "";
            this.tbConfermPassWord.ShadowDecoration.Parent = this.tbConfermPassWord;
            this.tbConfermPassWord.Size = new System.Drawing.Size(254, 31);
            this.tbConfermPassWord.TabIndex = 16;
            this.tbConfermPassWord.Validating += new System.ComponentModel.CancelEventHandler(this.PutErrorProvider);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Conferm PassWord :";
            // 
            // llSetPic
            // 
            this.llSetPic.AutoSize = true;
            this.llSetPic.Location = new System.Drawing.Point(725, 85);
            this.llSetPic.Name = "llSetPic";
            this.llSetPic.Size = new System.Drawing.Size(63, 16);
            this.llSetPic.TabIndex = 17;
            this.llSetPic.TabStop = true;
            this.llSetPic.Text = "Set Pictur";
            this.llSetPic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetPic_LinkClicked);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.AutoRoundedCorners = true;
            this.tbPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.tbPhoneNumber.BorderRadius = 14;
            this.tbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNumber.DefaultText = "";
            this.tbPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNumber.DisabledState.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.FocusedState.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.HoverState.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.Location = new System.Drawing.Point(135, 211);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PasswordChar = '\0';
            this.tbPhoneNumber.PlaceholderText = "";
            this.tbPhoneNumber.SelectedText = "";
            this.tbPhoneNumber.ShadowDecoration.Parent = this.tbPhoneNumber;
            this.tbPhoneNumber.Size = new System.Drawing.Size(254, 31);
            this.tbPhoneNumber.TabIndex = 20;
            this.tbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.PutErrorProvider);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Phone Number :";
            // 
            // btnSava
            // 
            this.btnSava.AutoRoundedCorners = true;
            this.btnSava.BorderRadius = 16;
            this.btnSava.CheckedState.Parent = this.btnSava;
            this.btnSava.CustomImages.Parent = this.btnSava;
            this.btnSava.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.btnSava.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSava.ForeColor = System.Drawing.Color.White;
            this.btnSava.HoverState.Parent = this.btnSava;
            this.btnSava.Location = new System.Drawing.Point(558, 386);
            this.btnSava.Name = "btnSava";
            this.btnSava.ShadowDecoration.Parent = this.btnSava;
            this.btnSava.Size = new System.Drawing.Size(95, 35);
            this.btnSava.TabIndex = 21;
            this.btnSava.Text = "Save";
            this.btnSava.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.AutoRoundedCorners = true;
            this.btnCansel.BorderRadius = 16;
            this.btnCansel.CheckedState.Parent = this.btnCansel;
            this.btnCansel.CustomImages.Parent = this.btnCansel;
            this.btnCansel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.btnCansel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCansel.ForeColor = System.Drawing.Color.White;
            this.btnCansel.HoverState.Parent = this.btnCansel;
            this.btnCansel.Location = new System.Drawing.Point(674, 387);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.ShadowDecoration.Parent = this.btnCansel;
            this.btnCansel.Size = new System.Drawing.Size(95, 35);
            this.btnCansel.TabIndex = 22;
            this.btnCansel.Text = "Cansel";
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbProfilPhoto
            // 
            this.pbProfilPhoto.Image = global::PizzaDesien.Properties.Resources.Untitled_design__6_;
            this.pbProfilPhoto.Location = new System.Drawing.Point(533, 104);
            this.pbProfilPhoto.Name = "pbProfilPhoto";
            this.pbProfilPhoto.ShadowDecoration.Parent = this.pbProfilPhoto;
            this.pbProfilPhoto.Size = new System.Drawing.Size(254, 138);
            this.pbProfilPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilPhoto.TabIndex = 23;
            this.pbProfilPhoto.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbProfilPhoto);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnSava);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.llSetPic);
            this.Controls.Add(this.tbConfermPassWord);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAddreass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBIrthDate);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBIrthDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbAddreass;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbPassWord;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox tbConfermPassWord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel llSetPic;
        private Guna.UI2.WinForms.Guna2TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnSava;
        private Guna.UI2.WinForms.Guna2Button btnCansel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2PictureBox pbProfilPhoto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}