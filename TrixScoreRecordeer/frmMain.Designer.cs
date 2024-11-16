namespace TrixScoreRecordeer
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlTabController1 = new TrixScoreRecordeer.ctrlTabController();
            this.ctrlTabController4 = new TrixScoreRecordeer.ctrlTabController();
            this.ctrlTabController3 = new TrixScoreRecordeer.ctrlTabController();
            this.ctrlTabController2 = new TrixScoreRecordeer.ctrlTabController();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.trixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kingOfHartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimondeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qeuensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(221)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.ctrlTabController1);
            this.panel1.Controls.Add(this.ctrlTabController4);
            this.panel1.Controls.Add(this.ctrlTabController3);
            this.panel1.Controls.Add(this.ctrlTabController2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 94);
            this.panel1.TabIndex = 0;
            // 
            // ctrlTabController1
            // 
            this.ctrlTabController1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(221)))), ((int)(((byte)(202)))));
            this.ctrlTabController1.Location = new System.Drawing.Point(0, -16);
            this.ctrlTabController1.Name = "ctrlTabController1";
            this.ctrlTabController1.Size = new System.Drawing.Size(91, 100);
            this.ctrlTabController1.TabIndex = 8;
            this.ctrlTabController1.TextNumber = "1";
            this.ctrlTabController1.Load += new System.EventHandler(this.ctrlTabController1_Load_1);
            this.ctrlTabController1.Click += new System.EventHandler(this.ctrlTabController1_Click);
            // 
            // ctrlTabController4
            // 
            this.ctrlTabController4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(221)))), ((int)(((byte)(202)))));
            this.ctrlTabController4.Location = new System.Drawing.Point(426, -16);
            this.ctrlTabController4.Name = "ctrlTabController4";
            this.ctrlTabController4.Size = new System.Drawing.Size(88, 101);
            this.ctrlTabController4.TabIndex = 7;
            this.ctrlTabController4.TextNumber = "4";
            this.ctrlTabController4.Load += new System.EventHandler(this.ctrlTabController4_Load);
            this.ctrlTabController4.Click += new System.EventHandler(this.ctrlTabController4_Click);
            // 
            // ctrlTabController3
            // 
            this.ctrlTabController3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(221)))), ((int)(((byte)(202)))));
            this.ctrlTabController3.Location = new System.Drawing.Point(285, -16);
            this.ctrlTabController3.Name = "ctrlTabController3";
            this.ctrlTabController3.Size = new System.Drawing.Size(88, 101);
            this.ctrlTabController3.TabIndex = 6;
            this.ctrlTabController3.TextNumber = "3";
            this.ctrlTabController3.Load += new System.EventHandler(this.ctrlTabController3_Load);
            this.ctrlTabController3.Click += new System.EventHandler(this.ctrlTabController3_Click);
            // 
            // ctrlTabController2
            // 
            this.ctrlTabController2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(221)))), ((int)(((byte)(202)))));
            this.ctrlTabController2.Location = new System.Drawing.Point(144, -16);
            this.ctrlTabController2.Name = "ctrlTabController2";
            this.ctrlTabController2.Size = new System.Drawing.Size(88, 101);
            this.ctrlTabController2.TabIndex = 5;
            this.ctrlTabController2.TextNumber = "2";
            this.ctrlTabController2.Load += new System.EventHandler(this.ctrlTabController2_Load);
            this.ctrlTabController2.Click += new System.EventHandler(this.ctrlTabController2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trixToolStripMenuItem,
            this.kingOfHartToolStripMenuItem,
            this.collactionToolStripMenuItem,
            this.dimondeToolStripMenuItem,
            this.qeuensToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 188);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(221)))), ((int)(((byte)(202)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(732, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.Size = new System.Drawing.Size(56, 58);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.ColumnHeadersHeight = 18;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(12, 119);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(776, 239);
            this.guna2DataGridView1.TabIndex = 2;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 18;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // trixToolStripMenuItem
            // 
            this.trixToolStripMenuItem.Image = global::TrixScoreRecordeer.Properties.Resources.icons8_cards_50;
            this.trixToolStripMenuItem.Name = "trixToolStripMenuItem";
            this.trixToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.trixToolStripMenuItem.Text = "Trix";
            this.trixToolStripMenuItem.Click += new System.EventHandler(this.trixToolStripMenuItem_Click);
            // 
            // kingOfHartToolStripMenuItem
            // 
            this.kingOfHartToolStripMenuItem.Image = global::TrixScoreRecordeer.Properties.Resources.icons8_king_96;
            this.kingOfHartToolStripMenuItem.Name = "kingOfHartToolStripMenuItem";
            this.kingOfHartToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.kingOfHartToolStripMenuItem.Text = "King Of Hart";
            this.kingOfHartToolStripMenuItem.Click += new System.EventHandler(this.kingOfHartToolStripMenuItem_Click);
            // 
            // collactionToolStripMenuItem
            // 
            this.collactionToolStripMenuItem.Image = global::TrixScoreRecordeer.Properties.Resources.icons8_cards_96;
            this.collactionToolStripMenuItem.Name = "collactionToolStripMenuItem";
            this.collactionToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.collactionToolStripMenuItem.Text = "Collactions";
            this.collactionToolStripMenuItem.Click += new System.EventHandler(this.collactionToolStripMenuItem_Click);
            // 
            // dimondeToolStripMenuItem
            // 
            this.dimondeToolStripMenuItem.Image = global::TrixScoreRecordeer.Properties.Resources.icons8_diamonds_96;
            this.dimondeToolStripMenuItem.Name = "dimondeToolStripMenuItem";
            this.dimondeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dimondeToolStripMenuItem.Text = "Dimonde";
            this.dimondeToolStripMenuItem.Click += new System.EventHandler(this.dimondeToolStripMenuItem_Click);
            // 
            // qeuensToolStripMenuItem
            // 
            this.qeuensToolStripMenuItem.Image = global::TrixScoreRecordeer.Properties.Resources.icons8_queen_96;
            this.qeuensToolStripMenuItem.Name = "qeuensToolStripMenuItem";
            this.qeuensToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.qeuensToolStripMenuItem.Text = "Qeuens";
            this.qeuensToolStripMenuItem.Click += new System.EventHandler(this.qeuensToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::TrixScoreRecordeer.Properties.Resources.icons8_edit_64;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kingOfHartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimondeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qeuensToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private ctrlTabController ctrlTabController4;
        private ctrlTabController ctrlTabController3;
        private ctrlTabController ctrlTabController2;
        private ctrlTabController ctrlTabController1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}

