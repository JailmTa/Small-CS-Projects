namespace PizzaDesien
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
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbThik = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbEat = new System.Windows.Forms.GroupBox();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.lSize = new System.Windows.Forms.Label();
            this.lSizeA = new System.Windows.Forms.Label();
            this.lExtraChees = new System.Windows.Forms.Label();
            this.lTopping = new System.Windows.Forms.Label();
            this.lCrustA = new System.Windows.Forms.Label();
            this.lCrust = new System.Windows.Forms.Label();
            this.lEatingPlaceA = new System.Windows.Forms.Label();
            this.lEatingPlace = new System.Windows.Forms.Label();
            this.lOnion = new System.Windows.Forms.Label();
            this.lOlives = new System.Windows.Forms.Label();
            this.lGreenPeppers = new System.Windows.Forms.Label();
            this.lTomatoes = new System.Windows.Forms.Label();
            this.lMushrooms = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lPriceA = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbT1 = new System.Windows.Forms.GroupBox();
            this.gbT2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbEat.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbT1.SuspendLayout();
            this.gbT2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.rbSmall.Location = new System.Drawing.Point(6, 17);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.rbMeduim.Location = new System.Drawing.Point(6, 51);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(76, 20);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "20";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = false;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.rbLarg.Location = new System.Drawing.Point(6, 85);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(55, 20);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.TabStop = true;
            this.rbLarg.Tag = "30";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = false;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbThik
            // 
            this.rbThik.AutoSize = true;
            this.rbThik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.rbThik.Location = new System.Drawing.Point(0, 66);
            this.rbThik.Name = "rbThik";
            this.rbThik.Size = new System.Drawing.Size(87, 20);
            this.rbThik.TabIndex = 4;
            this.rbThik.TabStop = true;
            this.rbThik.Tag = "20";
            this.rbThik.Text = "Thik Curst";
            this.rbThik.UseVisualStyleBackColor = false;
            this.rbThik.CheckedChanged += new System.EventHandler(this.rbThik_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.rbThin.Location = new System.Drawing.Point(0, 21);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(87, 20);
            this.rbThin.TabIndex = 3;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "10";
            this.rbThin.Text = "Thin Curst";
            this.rbThin.UseVisualStyleBackColor = false;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.rbEatOut.Location = new System.Drawing.Point(2, 66);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(71, 20);
            this.rbEatOut.TabIndex = 6;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Eat Out";
            this.rbEatOut.UseVisualStyleBackColor = false;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rbEatOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.rbEatIn.Location = new System.Drawing.Point(2, 21);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 5;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = false;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbEat
            // 
            this.gbEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.gbEat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbEat.Controls.Add(this.rbEatOut);
            this.gbEat.Controls.Add(this.rbEatIn);
            this.gbEat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbEat.ForeColor = System.Drawing.Color.Black;
            this.gbEat.Location = new System.Drawing.Point(286, 328);
            this.gbEat.Name = "gbEat";
            this.gbEat.Size = new System.Drawing.Size(96, 90);
            this.gbEat.TabIndex = 7;
            this.gbEat.TabStop = false;
            this.gbEat.Enter += new System.EventHandler(this.gbEat_Enter);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Controls.Add(this.rbThik);
            this.gbCrust.Location = new System.Drawing.Point(69, 328);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(110, 90);
            this.gbCrust.TabIndex = 8;
            this.gbCrust.TabStop = false;
            this.gbCrust.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.chkExtraChees.Location = new System.Drawing.Point(3, 12);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(101, 20);
            this.chkExtraChees.TabIndex = 9;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = false;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.chkMushrooms.Location = new System.Drawing.Point(3, 46);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chkMushrooms.TabIndex = 10;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = false;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.chkTomatoes.Location = new System.Drawing.Point(3, 80);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chkTomatoes.TabIndex = 11;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = false;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.chkGreenPeppers.Location = new System.Drawing.Point(6, 75);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(118, 20);
            this.chkGreenPeppers.TabIndex = 14;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "GreenPeppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = false;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.chkOlives.Location = new System.Drawing.Point(6, 41);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 13;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = false;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.chkOnion.Location = new System.Drawing.Point(6, 7);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 12;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = false;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSize.Location = new System.Drawing.Point(682, 124);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(66, 22);
            this.lSize.TabIndex = 15;
            this.lSize.Text = "Size : ";
            this.lSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // lSizeA
            // 
            this.lSizeA.AutoSize = true;
            this.lSizeA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lSizeA.Location = new System.Drawing.Point(775, 124);
            this.lSizeA.Name = "lSizeA";
            this.lSizeA.Size = new System.Drawing.Size(0, 16);
            this.lSizeA.TabIndex = 16;
            // 
            // lExtraChees
            // 
            this.lExtraChees.AutoSize = true;
            this.lExtraChees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lExtraChees.Location = new System.Drawing.Point(683, 215);
            this.lExtraChees.Name = "lExtraChees";
            this.lExtraChees.Size = new System.Drawing.Size(0, 16);
            this.lExtraChees.TabIndex = 18;
            // 
            // lTopping
            // 
            this.lTopping.AutoSize = true;
            this.lTopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTopping.Location = new System.Drawing.Point(682, 173);
            this.lTopping.Name = "lTopping";
            this.lTopping.Size = new System.Drawing.Size(101, 22);
            this.lTopping.TabIndex = 17;
            this.lTopping.Text = "Topping : ";
            // 
            // lCrustA
            // 
            this.lCrustA.AutoSize = true;
            this.lCrustA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lCrustA.Location = new System.Drawing.Point(683, 367);
            this.lCrustA.Name = "lCrustA";
            this.lCrustA.Size = new System.Drawing.Size(0, 16);
            this.lCrustA.TabIndex = 20;
            this.lCrustA.Click += new System.EventHandler(this.label3_Click);
            // 
            // lCrust
            // 
            this.lCrust.AutoSize = true;
            this.lCrust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCrust.Location = new System.Drawing.Point(682, 328);
            this.lCrust.Name = "lCrust";
            this.lCrust.Size = new System.Drawing.Size(121, 22);
            this.lCrust.TabIndex = 19;
            this.lCrust.Text = "Crust Type :";
            this.lCrust.Click += new System.EventHandler(this.lCrust_Click);
            // 
            // lEatingPlaceA
            // 
            this.lEatingPlaceA.AutoSize = true;
            this.lEatingPlaceA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lEatingPlaceA.Location = new System.Drawing.Point(683, 429);
            this.lEatingPlaceA.Name = "lEatingPlaceA";
            this.lEatingPlaceA.Size = new System.Drawing.Size(0, 16);
            this.lEatingPlaceA.TabIndex = 22;
            // 
            // lEatingPlace
            // 
            this.lEatingPlace.AutoSize = true;
            this.lEatingPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lEatingPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEatingPlace.Location = new System.Drawing.Point(682, 396);
            this.lEatingPlace.Name = "lEatingPlace";
            this.lEatingPlace.Size = new System.Drawing.Size(141, 22);
            this.lEatingPlace.TabIndex = 21;
            this.lEatingPlace.Text = "Eating Place : ";
            // 
            // lOnion
            // 
            this.lOnion.AutoSize = true;
            this.lOnion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lOnion.Location = new System.Drawing.Point(775, 215);
            this.lOnion.Name = "lOnion";
            this.lOnion.Size = new System.Drawing.Size(0, 16);
            this.lOnion.TabIndex = 23;
            // 
            // lOlives
            // 
            this.lOlives.AutoSize = true;
            this.lOlives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lOlives.Location = new System.Drawing.Point(775, 253);
            this.lOlives.Name = "lOlives";
            this.lOlives.Size = new System.Drawing.Size(0, 16);
            this.lOlives.TabIndex = 24;
            // 
            // lGreenPeppers
            // 
            this.lGreenPeppers.AutoSize = true;
            this.lGreenPeppers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lGreenPeppers.Location = new System.Drawing.Point(775, 291);
            this.lGreenPeppers.Name = "lGreenPeppers";
            this.lGreenPeppers.Size = new System.Drawing.Size(0, 16);
            this.lGreenPeppers.TabIndex = 25;
            // 
            // lTomatoes
            // 
            this.lTomatoes.AutoSize = true;
            this.lTomatoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lTomatoes.Location = new System.Drawing.Point(683, 291);
            this.lTomatoes.Name = "lTomatoes";
            this.lTomatoes.Size = new System.Drawing.Size(0, 16);
            this.lTomatoes.TabIndex = 26;
            // 
            // lMushrooms
            // 
            this.lMushrooms.AutoSize = true;
            this.lMushrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lMushrooms.Location = new System.Drawing.Point(683, 253);
            this.lMushrooms.Name = "lMushrooms";
            this.lMushrooms.Size = new System.Drawing.Size(0, 16);
            this.lMushrooms.TabIndex = 27;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrice.Location = new System.Drawing.Point(682, 468);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(74, 22);
            this.lPrice.TabIndex = 28;
            this.lPrice.Text = "Price : ";
            // 
            // lPriceA
            // 
            this.lPriceA.AutoSize = true;
            this.lPriceA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.lPriceA.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPriceA.ForeColor = System.Drawing.Color.ForestGreen;
            this.lPriceA.Location = new System.Drawing.Point(756, 466);
            this.lPriceA.Name = "lPriceA";
            this.lPriceA.Size = new System.Drawing.Size(0, 61);
            this.lPriceA.TabIndex = 29;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(450, 497);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 40);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(178, 497);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(116, 40);
            this.btnOrder.TabIndex = 31;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnRest.FlatAppearance.BorderSize = 0;
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.Location = new System.Drawing.Point(314, 497);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(116, 40);
            this.btnRest.TabIndex = 32;
            this.btnRest.Text = "Reset";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Controls.Add(this.rbMeduim);
            this.groupBox1.Controls.Add(this.rbLarg);
            this.groupBox1.Location = new System.Drawing.Point(69, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 105);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // gbT1
            // 
            this.gbT1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.gbT1.Controls.Add(this.chkExtraChees);
            this.gbT1.Controls.Add(this.chkMushrooms);
            this.gbT1.Controls.Add(this.chkTomatoes);
            this.gbT1.Location = new System.Drawing.Point(285, 73);
            this.gbT1.Name = "gbT1";
            this.gbT1.Size = new System.Drawing.Size(110, 105);
            this.gbT1.TabIndex = 34;
            this.gbT1.TabStop = false;
            // 
            // gbT2
            // 
            this.gbT2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.gbT2.Controls.Add(this.chkOnion);
            this.gbT2.Controls.Add(this.chkOlives);
            this.gbT2.Controls.Add(this.chkGreenPeppers);
            this.gbT2.Location = new System.Drawing.Point(385, 73);
            this.gbT2.Name = "gbT2";
            this.gbT2.Size = new System.Drawing.Size(130, 105);
            this.gbT2.TabIndex = 35;
            this.gbT2.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(51, 505);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 22);
            this.numericUpDown1.TabIndex = 36;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form2
            // 
      //      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaDesien.Properties.Resources.Its_Your_Pizza_Time_20240625_205210_0001;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gbT2);
            this.Controls.Add(this.gbT1);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lPriceA);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.lMushrooms);
            this.Controls.Add(this.lTomatoes);
            this.Controls.Add(this.lGreenPeppers);
            this.Controls.Add(this.lOlives);
            this.Controls.Add(this.lOnion);
            this.Controls.Add(this.lEatingPlaceA);
            this.Controls.Add(this.lEatingPlace);
            this.Controls.Add(this.lCrustA);
            this.Controls.Add(this.lCrust);
            this.Controls.Add(this.lExtraChees);
            this.Controls.Add(this.lTopping);
            this.Controls.Add(this.lSizeA);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbEat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbEat.ResumeLayout(false);
            this.gbEat.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbT1.ResumeLayout(false);
            this.gbT1.PerformLayout();
            this.gbT2.ResumeLayout(false);
            this.gbT2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbThik;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbEat;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lSizeA;
        private System.Windows.Forms.Label lExtraChees;
        private System.Windows.Forms.Label lTopping;
        private System.Windows.Forms.Label lCrustA;
        private System.Windows.Forms.Label lCrust;
        private System.Windows.Forms.Label lEatingPlaceA;
        private System.Windows.Forms.Label lEatingPlace;
        private System.Windows.Forms.Label lOnion;
        private System.Windows.Forms.Label lOlives;
        private System.Windows.Forms.Label lGreenPeppers;
        private System.Windows.Forms.Label lTomatoes;
        private System.Windows.Forms.Label lMushrooms;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lPriceA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbT1;
        private System.Windows.Forms.GroupBox gbT2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}