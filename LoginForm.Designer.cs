namespace BankingSystem
{
    partial class LoginForm
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnnotshow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPasschk = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserchk = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnnotshow);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.lblPasschk);
            this.panel6.Controls.Add(this.txtPassword);
            this.panel6.Location = new System.Drawing.Point(164, 189);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 66);
            this.panel6.TabIndex = 13;
            // 
            // btnnotshow
            // 
            this.btnnotshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnnotshow.BackgroundImage = global::BankingSystem.Properties.Resources.icons8_not_visible_50;
            this.btnnotshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnotshow.FlatAppearance.BorderSize = 0;
            this.btnnotshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnotshow.Location = new System.Drawing.Point(22, 23);
            this.btnnotshow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnnotshow.Name = "btnnotshow";
            this.btnnotshow.Size = new System.Drawing.Size(22, 20);
            this.btnnotshow.TabIndex = 4;
            this.btnnotshow.UseVisualStyleBackColor = false;
            this.btnnotshow.Click += new System.EventHandler(this.btnnotshow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BankingSystem.Properties.Resources.padlock;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(226, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lblPasschk
            // 
            this.lblPasschk.AutoSize = true;
            this.lblPasschk.ForeColor = System.Drawing.Color.Red;
            this.lblPasschk.Location = new System.Drawing.Point(141, 46);
            this.lblPasschk.Name = "lblPasschk";
            this.lblPasschk.Size = new System.Drawing.Size(87, 13);
            this.lblPasschk.TabIndex = 5;
            this.lblPasschk.Text = "Invalid Password";
            this.lblPasschk.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(22, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnshow.BackgroundImage = global::BankingSystem.Properties.Resources.icons8_visible_50;
            this.btnshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnshow.Location = new System.Drawing.Point(137, 214);
            this.btnshow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(22, 18);
            this.btnshow.TabIndex = 5;
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblUserchk);
            this.panel5.Controls.Add(this.txtUsername);
            this.panel5.Location = new System.Drawing.Point(164, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 66);
            this.panel5.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankingSystem.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            // 
            // lblUserchk
            // 
            this.lblUserchk.AutoSize = true;
            this.lblUserchk.BackColor = System.Drawing.Color.Transparent;
            this.lblUserchk.ForeColor = System.Drawing.Color.Red;
            this.lblUserchk.Location = new System.Drawing.Point(45, 46);
            this.lblUserchk.Name = "lblUserchk";
            this.lblUserchk.Size = new System.Drawing.Size(89, 13);
            this.lblUserchk.TabIndex = 5;
            this.lblUserchk.Text = "Invalid Username";
            this.lblUserchk.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(40, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(211, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Enter Username";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::BankingSystem.Properties.Resources.close;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Image = global::BankingSystem.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(505, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 34);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 14;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(209, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "No account? Register here";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnLogin.Location = new System.Drawing.Point(212, 273);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 29);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankingSystem.Properties.Resources.ChatGPT_Image_May_4__2026__03_13_19_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 398);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnnotshow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPasschk;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserchk;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}

