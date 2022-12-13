using System.Windows.Forms;

namespace misis_mp3_pleer
{
    partial class Form_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_register));
            this.Label_top = new System.Windows.Forms.Label();
            this.password_box_1 = new System.Windows.Forms.TextBox();
            this.Button_enter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sucsess_reg = new System.Windows.Forms.Label();
            this.mistake_reg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_box_2 = new System.Windows.Forms.TextBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_top
            // 
            this.Label_top.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.Label_top.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_top.Font = new System.Drawing.Font("Montserrat ExtraBold", 30F, System.Drawing.FontStyle.Bold);
            this.Label_top.ForeColor = System.Drawing.Color.Transparent;
            this.Label_top.Location = new System.Drawing.Point(354, 88);
            this.Label_top.Margin = new System.Windows.Forms.Padding(0);
            this.Label_top.Name = "Label_top";
            this.Label_top.Size = new System.Drawing.Size(398, 87);
            this.Label_top.TabIndex = 2;
            this.Label_top.Text = "Регистрация";
            this.Label_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_top.Click += new System.EventHandler(this.Label_top_Click);
            // 
            // password_box_1
            // 
            this.password_box_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_box_1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.password_box_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_box_1.Font = new System.Drawing.Font("Montserrat ExtraBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.password_box_1.Location = new System.Drawing.Point(350, 341);
            this.password_box_1.Name = "password_box_1";
            this.password_box_1.PasswordChar = '*';
            this.password_box_1.Size = new System.Drawing.Size(440, 41);
            this.password_box_1.TabIndex = 6;
            this.password_box_1.Text = "example";
            this.password_box_1.UseSystemPasswordChar = true;
            this.password_box_1.MouseEnter += new System.EventHandler(this.password_box_1_MouseEnter);
            // 
            // Button_enter
            // 
            this.Button_enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.Button_enter.Font = new System.Drawing.Font("Montserrat ExtraBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Button_enter.ForeColor = System.Drawing.Color.Transparent;
            this.Button_enter.Location = new System.Drawing.Point(366, 512);
            this.Button_enter.Name = "Button_enter";
            this.Button_enter.Size = new System.Drawing.Size(396, 48);
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
            this.button1.Location = new System.Drawing.Point(844, 1037);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.sucsess_reg);
            this.panel1.Controls.Add(this.mistake_reg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.password_box_2);
            this.panel1.Controls.Add(this.login_box);
            this.panel1.Controls.Add(this.Button_enter);
            this.panel1.Controls.Add(this.Label_top);
            this.panel1.Controls.Add(this.password_box_1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 659);
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
            this.sucsess_reg.Location = new System.Drawing.Point(0, 565);
            this.sucsess_reg.Margin = new System.Windows.Forms.Padding(0);
            this.sucsess_reg.Name = "sucsess_reg";
            this.sucsess_reg.Size = new System.Drawing.Size(1142, 47);
            this.sucsess_reg.TabIndex = 16;
            this.sucsess_reg.Text = "Успешная регистрация!";
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
            this.mistake_reg.Location = new System.Drawing.Point(0, 612);
            this.mistake_reg.Margin = new System.Windows.Forms.Padding(0);
            this.mistake_reg.Name = "mistake_reg";
            this.mistake_reg.Size = new System.Drawing.Size(1142, 47);
            this.mistake_reg.TabIndex = 17;
            this.mistake_reg.Text = "Пароли введены неверно!";
            this.mistake_reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mistake_reg.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(317, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 54);
            this.label3.TabIndex = 15;
            this.label3.Text = "Придймайте логин: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(317, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 54);
            this.label2.TabIndex = 14;
            this.label2.Text = "Повторите пароль: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(94)))), ((int)(((byte)(168)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(317, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "Придймайте пароль: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_box_2
            // 
            this.password_box_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_box_2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.password_box_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_box_2.Font = new System.Drawing.Font("Montserrat ExtraBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.password_box_2.Location = new System.Drawing.Point(350, 442);
            this.password_box_2.Name = "password_box_2";
            this.password_box_2.PasswordChar = '*';
            this.password_box_2.Size = new System.Drawing.Size(440, 41);
            this.password_box_2.TabIndex = 12;
            this.password_box_2.Text = "example";
            this.password_box_2.UseSystemPasswordChar = true;
            this.password_box_2.MouseEnter += new System.EventHandler(this.password_box_2_MouseEnter);
            // 
            // login_box
            // 
            this.login_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.login_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_box.Font = new System.Drawing.Font("Montserrat ExtraBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.login_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.login_box.Location = new System.Drawing.Point(350, 232);
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
            this.pictureBox1.Location = new System.Drawing.Point(-209, -95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1536, 852);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1142, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(64, 64);
            this.Name = "Form_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_register_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_register_FormClosed);
            this.Load += new System.EventHandler(this.Form_register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label Label_top;
        private TextBox password_box_1;
        private Button Button_enter;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox login_box;
        private Label label2;
        private Label label1;
        private TextBox password_box_2;
        private Label label3;
        private Label sucsess_reg;
        private Label mistake_reg;
    }

}
