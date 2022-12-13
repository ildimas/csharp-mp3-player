using System.Windows.Forms;

namespace misis_mp3_pleer
{
    partial class Form_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.Label_top = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.Button_enter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_registration = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sucsess_reg = new System.Windows.Forms.Label();
            this.mistake_reg = new System.Windows.Forms.Label();
            this.login_box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_top
            // 
            this.Label_top.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_top.BackColor = System.Drawing.Color.DodgerBlue;
            this.Label_top.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_top.Font = new System.Drawing.Font("Montserrat ExtraBold", 30F, System.Drawing.FontStyle.Bold);
            this.Label_top.ForeColor = System.Drawing.Color.Transparent;
            this.Label_top.Location = new System.Drawing.Point(336, 160);
            this.Label_top.Margin = new System.Windows.Forms.Padding(0);
            this.Label_top.Name = "Label_top";
            this.Label_top.Size = new System.Drawing.Size(468, 86);
            this.Label_top.TabIndex = 2;
            this.Label_top.Text = "Авторизация";
            this.Label_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_box
            // 
            this.password_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.password_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_box.Font = new System.Drawing.Font("Montserrat ExtraBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.password_box.Location = new System.Drawing.Point(348, 321);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(440, 41);
            this.password_box.TabIndex = 6;
            this.password_box.Text = "example";
            this.password_box.UseSystemPasswordChar = true;
            this.password_box.MouseEnter += new System.EventHandler(this.password_box_MouseEnter);
            // 
            // Button_enter
            // 
            this.Button_enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_enter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_enter.Font = new System.Drawing.Font("Montserrat ExtraBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Button_enter.ForeColor = System.Drawing.Color.Transparent;
            this.Button_enter.Location = new System.Drawing.Point(348, 394);
            this.Button_enter.Name = "Button_enter";
            this.Button_enter.Size = new System.Drawing.Size(440, 48);
            this.Button_enter.TabIndex = 7;
            this.Button_enter.Text = "Войти";
            this.Button_enter.UseVisualStyleBackColor = false;
            this.Button_enter.Click += new System.EventHandler(this.Button_enter_Click);
            this.Button_enter.MouseEnter += new System.EventHandler(this.Button_enter_MouseEnter);
            this.Button_enter.MouseLeave += new System.EventHandler(this.Button_enter_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Montserrat ExtraBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(697, 843);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_registration
            // 
            this.button_registration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_registration.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_registration.Font = new System.Drawing.Font("Montserrat ExtraBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.button_registration.Location = new System.Drawing.Point(348, 460);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(440, 48);
            this.button_registration.TabIndex = 10;
            this.button_registration.Text = "Зарегистрироваться";
            this.button_registration.UseVisualStyleBackColor = false;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            this.button_registration.MouseEnter += new System.EventHandler(this.button_registration_MouseEnter);
            this.button_registration.MouseLeave += new System.EventHandler(this.button_registration_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.sucsess_reg);
            this.panel1.Controls.Add(this.mistake_reg);
            this.panel1.Controls.Add(this.login_box);
            this.panel1.Controls.Add(this.button_registration);
            this.panel1.Controls.Add(this.Label_top);
            this.panel1.Controls.Add(this.password_box);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 659);
            this.panel1.TabIndex = 11;
            // 
            // sucsess_reg
            // 
            this.sucsess_reg.BackColor = System.Drawing.Color.ForestGreen;
            this.sucsess_reg.Cursor = System.Windows.Forms.Cursors.Default;
            this.sucsess_reg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sucsess_reg.Enabled = false;
            this.sucsess_reg.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold);
            this.sucsess_reg.ForeColor = System.Drawing.Color.Transparent;
            this.sucsess_reg.Location = new System.Drawing.Point(0, 477);
            this.sucsess_reg.Margin = new System.Windows.Forms.Padding(0);
            this.sucsess_reg.Name = "sucsess_reg";
            this.sucsess_reg.Size = new System.Drawing.Size(1141, 89);
            this.sucsess_reg.TabIndex = 19;
            this.sucsess_reg.Text = "Успешная авторизация!";
            this.sucsess_reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sucsess_reg.Visible = false;
            // 
            // mistake_reg
            // 
            this.mistake_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mistake_reg.Cursor = System.Windows.Forms.Cursors.Default;
            this.mistake_reg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mistake_reg.Enabled = false;
            this.mistake_reg.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold);
            this.mistake_reg.ForeColor = System.Drawing.Color.Transparent;
            this.mistake_reg.Location = new System.Drawing.Point(0, 566);
            this.mistake_reg.Margin = new System.Windows.Forms.Padding(0);
            this.mistake_reg.Name = "mistake_reg";
            this.mistake_reg.Size = new System.Drawing.Size(1141, 93);
            this.mistake_reg.TabIndex = 18;
            this.mistake_reg.Text = "Не удалось войти!";
            this.mistake_reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mistake_reg.Visible = false;
            // 
            // login_box
            // 
            this.login_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.login_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_box.Font = new System.Drawing.Font("Montserrat ExtraBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.login_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.login_box.Location = new System.Drawing.Point(348, 265);
            this.login_box.Multiline = true;
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(440, 49);
            this.login_box.TabIndex = 11;
            this.login_box.Text = "Логин:";
            this.login_box.UseSystemPasswordChar = true;
            this.login_box.MouseEnter += new System.EventHandler(this.login_box_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-39, -55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1185, 765);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1141, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_enter);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(64, 64);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label Label_top;
        private TextBox password_box;
        private Button Button_enter;
        private Button button1;
        private Button button_registration;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox login_box;
        private Label mistake_reg;
        private Label sucsess_reg;
    }

}
