namespace TrainTuto
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordTb = new Guna.UI.WinForms.GunaTextBox();
            this.UNameTb = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LoginBtn = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PasswordTb);
            this.panel1.Controls.Add(this.UNameTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(28, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 443);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PasswordTb
            // 
            this.PasswordTb.BaseColor = System.Drawing.Color.White;
            this.PasswordTb.BorderColor = System.Drawing.Color.Silver;
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.FocusedBaseColor = System.Drawing.Color.White;
            this.PasswordTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PasswordTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(154, 234);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.SelectedText = "";
            this.PasswordTb.Size = new System.Drawing.Size(306, 30);
            this.PasswordTb.TabIndex = 52;
            this.PasswordTb.Text = "gunaTextBox2";
            // 
            // UNameTb
            // 
            this.UNameTb.BaseColor = System.Drawing.Color.White;
            this.UNameTb.BorderColor = System.Drawing.Color.Silver;
            this.UNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UNameTb.FocusedBaseColor = System.Drawing.Color.White;
            this.UNameTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UNameTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.UNameTb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNameTb.Location = new System.Drawing.Point(154, 166);
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.PasswordChar = '\0';
            this.UNameTb.SelectedText = "";
            this.UNameTb.Size = new System.Drawing.Size(306, 30);
            this.UNameTb.TabIndex = 51;
            this.UNameTb.Text = "gunaTextBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(555, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "X";
            // 
            // ResetBtn
            // 
            this.ResetBtn.AutoSize = true;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.Red;
            this.ResetBtn.Location = new System.Drawing.Point(273, 365);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(57, 20);
            this.ResetBtn.TabIndex = 49;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(181, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "+";
            // 
            // LoginBtn
            // 
            this.LoginBtn.AnimationHoverSpeed = 0.07F;
            this.LoginBtn.AnimationSpeed = 0.03F;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BaseColor = System.Drawing.Color.Yellow;
            this.LoginBtn.BorderColor = System.Drawing.Color.Black;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LoginBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Image = null;
            this.LoginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginBtn.Location = new System.Drawing.Point(94, 310);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBaseColor = System.Drawing.Color.Yellow;
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnHoverImage = null;
            this.LoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LoginBtn.Radius = 15;
            this.LoginBtn.Size = new System.Drawing.Size(425, 42);
            this.LoginBtn.TabIndex = 45;
            this.LoginBtn.Text = "Login Into The System";
            this.LoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(150, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(150, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "UserName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(208, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "Train Ticket Booking";
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 5;
            this.gunaElipse2.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(649, 502);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton LoginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ResetBtn;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox PasswordTb;
        private Guna.UI.WinForms.GunaTextBox UNameTb;
    }
}