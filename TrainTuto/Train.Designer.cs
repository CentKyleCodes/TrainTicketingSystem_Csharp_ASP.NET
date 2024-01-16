namespace TrainTuto
{
    partial class Train
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Train));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Label();
            this.TrainsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.AddBtn = new Guna.UI.WinForms.GunaButton();
            this.TColorTb = new Guna.UI.WinForms.GunaTextBox();
            this.TConditionTb = new Guna.UI.WinForms.GunaTextBox();
            this.TNameTb = new Guna.UI.WinForms.GunaTextBox();
            this.TNumberTb = new Guna.UI.WinForms.GunaTextBox();
            this.InDateTb = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TCapacityTb = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.TrainsDGV);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.TColorTb);
            this.panel1.Controls.Add(this.TConditionTb);
            this.panel1.Controls.Add(this.TNameTb);
            this.panel1.Controls.Add(this.TNumberTb);
            this.panel1.Controls.Add(this.InDateTb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TCapacityTb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(50, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 597);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = true;
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.ForeColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.Location = new System.Drawing.Point(258, 328);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(57, 22);
            this.DeleteBtn.TabIndex = 36;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.BackColor = System.Drawing.Color.Transparent;
            this.Update.ForeColor = System.Drawing.Color.ForestGreen;
            this.Update.Location = new System.Drawing.Point(193, 328);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(61, 22);
            this.Update.TabIndex = 35;
            this.Update.Text = "Update";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // TrainsDGV
            // 
            this.TrainsDGV.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TrainsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TrainsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrainsDGV.BackgroundColor = System.Drawing.Color.OldLace;
            this.TrainsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrainsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrainsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TrainsDGV.ColumnHeadersHeight = 10;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrainsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TrainsDGV.EnableHeadersVisualStyles = false;
            this.TrainsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TrainsDGV.Location = new System.Drawing.Point(498, 33);
            this.TrainsDGV.Name = "TrainsDGV";
            this.TrainsDGV.RowHeadersVisible = false;
            this.TrainsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrainsDGV.Size = new System.Drawing.Size(721, 549);
            this.TrainsDGV.TabIndex = 34;
            this.TrainsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.TrainsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TrainsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TrainsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TrainsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TrainsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TrainsDGV.ThemeStyle.BackColor = System.Drawing.Color.OldLace;
            this.TrainsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TrainsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TrainsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.TrainsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TrainsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TrainsDGV.ThemeStyle.HeaderStyle.Height = 10;
            this.TrainsDGV.ThemeStyle.ReadOnly = false;
            this.TrainsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TrainsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TrainsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.TrainsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.TrainsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TrainsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TrainsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainsDGV_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(157, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "+";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AnimationHoverSpeed = 0.07F;
            this.AddBtn.AnimationSpeed = 0.03F;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddBtn.BorderColor = System.Drawing.Color.Black;
            this.AddBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Image = null;
            this.AddBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.AddBtn.Location = new System.Drawing.Point(58, 269);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddBtn.OnHoverImage = null;
            this.AddBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddBtn.Radius = 15;
            this.AddBtn.Size = new System.Drawing.Size(412, 42);
            this.AddBtn.TabIndex = 32;
            this.AddBtn.Text = "Add New Train";
            this.AddBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TColorTb
            // 
            this.TColorTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TColorTb.BaseColor = System.Drawing.Color.White;
            this.TColorTb.BorderColor = System.Drawing.Color.Silver;
            this.TColorTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TColorTb.FocusedBaseColor = System.Drawing.Color.White;
            this.TColorTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TColorTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TColorTb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TColorTb.Location = new System.Drawing.Point(260, 209);
            this.TColorTb.Name = "TColorTb";
            this.TColorTb.PasswordChar = '\0';
            this.TColorTb.SelectedText = "";
            this.TColorTb.Size = new System.Drawing.Size(210, 37);
            this.TColorTb.TabIndex = 31;
            this.TColorTb.Text = "gunaTextBox4";
            // 
            // TConditionTb
            // 
            this.TConditionTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TConditionTb.BaseColor = System.Drawing.Color.White;
            this.TConditionTb.BorderColor = System.Drawing.Color.Silver;
            this.TConditionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TConditionTb.FocusedBaseColor = System.Drawing.Color.White;
            this.TConditionTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TConditionTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TConditionTb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TConditionTb.Location = new System.Drawing.Point(260, 132);
            this.TConditionTb.Name = "TConditionTb";
            this.TConditionTb.PasswordChar = '\0';
            this.TConditionTb.SelectedText = "";
            this.TConditionTb.Size = new System.Drawing.Size(210, 37);
            this.TConditionTb.TabIndex = 30;
            this.TConditionTb.Text = "gunaTextBox2";
            // 
            // TNameTb
            // 
            this.TNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TNameTb.BaseColor = System.Drawing.Color.White;
            this.TNameTb.BorderColor = System.Drawing.Color.Silver;
            this.TNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TNameTb.FocusedBaseColor = System.Drawing.Color.White;
            this.TNameTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TNameTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TNameTb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNameTb.Location = new System.Drawing.Point(60, 58);
            this.TNameTb.Name = "TNameTb";
            this.TNameTb.PasswordChar = '\0';
            this.TNameTb.SelectedText = "";
            this.TNameTb.Size = new System.Drawing.Size(196, 37);
            this.TNameTb.TabIndex = 29;
            this.TNameTb.Text = "gunaTextBox1";
            this.TNameTb.TextChanged += new System.EventHandler(this.TNameTb_TextChanged);
            // 
            // TNumberTb
            // 
            this.TNumberTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TNumberTb.BaseColor = System.Drawing.Color.White;
            this.TNumberTb.BorderColor = System.Drawing.Color.Silver;
            this.TNumberTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TNumberTb.FocusedBaseColor = System.Drawing.Color.White;
            this.TNumberTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TNumberTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TNumberTb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNumberTb.Location = new System.Drawing.Point(58, 132);
            this.TNumberTb.Name = "TNumberTb";
            this.TNumberTb.PasswordChar = '\0';
            this.TNumberTb.SelectedText = "";
            this.TNumberTb.Size = new System.Drawing.Size(196, 37);
            this.TNumberTb.TabIndex = 28;
            this.TNumberTb.Text = "gunaTextBox6";
            // 
            // InDateTb
            // 
            this.InDateTb.BaseColor = System.Drawing.Color.ForestGreen;
            this.InDateTb.BorderColor = System.Drawing.Color.Silver;
            this.InDateTb.CustomFormat = null;
            this.InDateTb.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.InDateTb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.InDateTb.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InDateTb.ForeColor = System.Drawing.Color.White;
            this.InDateTb.Location = new System.Drawing.Point(262, 65);
            this.InDateTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.InDateTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.InDateTb.Name = "InDateTb";
            this.InDateTb.OnHoverBaseColor = System.Drawing.Color.White;
            this.InDateTb.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.InDateTb.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.InDateTb.OnPressedColor = System.Drawing.Color.Black;
            this.InDateTb.Size = new System.Drawing.Size(208, 30);
            this.InDateTb.TabIndex = 27;
            this.InDateTb.Text = "Wednesday, 3 January 2024";
            this.InDateTb.Value = new System.DateTime(2024, 1, 3, 0, 3, 17, 177);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(256, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Train Color";
            // 
            // TCapacityTb
            // 
            this.TCapacityTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TCapacityTb.BaseColor = System.Drawing.Color.White;
            this.TCapacityTb.BorderColor = System.Drawing.Color.Silver;
            this.TCapacityTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCapacityTb.FocusedBaseColor = System.Drawing.Color.White;
            this.TCapacityTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TCapacityTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TCapacityTb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCapacityTb.Location = new System.Drawing.Point(58, 209);
            this.TCapacityTb.Name = "TCapacityTb";
            this.TCapacityTb.PasswordChar = '\0';
            this.TCapacityTb.SelectedText = "";
            this.TCapacityTb.Size = new System.Drawing.Size(196, 37);
            this.TCapacityTb.TabIndex = 23;
            this.TCapacityTb.Text = "gunaTextBox3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(258, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Train Condition";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(56, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Train Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(56, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Train Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Train Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 684);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(503, 684);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(623, 684);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(744, 684);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(385, 684);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(859, 684);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(965, 684);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(62, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Train Ticket Reservation Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 20;
            this.gunaElipse2.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(88, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 24);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "+";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Train Management";
            // 
            // Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1403, 767);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Train";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDateTimePicker InDateTb;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox TCapacityTb;
        private Guna.UI.WinForms.GunaButton AddBtn;
        private Guna.UI.WinForms.GunaTextBox TColorTb;
        private Guna.UI.WinForms.GunaTextBox TConditionTb;
        private Guna.UI.WinForms.GunaTextBox TNameTb;
        private Guna.UI.WinForms.GunaTextBox TNumberTb;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaDataGridView TrainsDGV;
        private System.Windows.Forms.Label DeleteBtn;
        private System.Windows.Forms.Label Update;
    }
}

