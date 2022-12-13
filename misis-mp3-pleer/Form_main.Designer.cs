using System.Windows.Forms;

namespace misis_mp3_pleer
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.save_songs_btn = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.Chose_songs_btn = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.user_id_label = new System.Windows.Forms.Label();
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ran_button = new System.Windows.Forms.PictureBox();
            this.loop_button = new System.Windows.Forms.PictureBox();
            this.previous_track = new System.Windows.Forms.PictureBox();
            this.next_track = new System.Windows.Forms.PictureBox();
            this.label_100 = new System.Windows.Forms.Label();
            this.pause_play = new System.Windows.Forms.PictureBox();
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.time_label = new System.Windows.Forms.Label();
            this.song_name_label = new System.Windows.Forms.Label();
            this.song_line = new System.Windows.Forms.ProgressBar();
            this.playlist_list = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.labeL_picture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.save_songs_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ran_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loop_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labeL_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // save_songs_btn
            // 
            this.save_songs_btn.BackColor = System.Drawing.Color.LightBlue;
            this.save_songs_btn.Controls.Add(this.delete_button);
            this.save_songs_btn.Controls.Add(this.save_button);
            this.save_songs_btn.Controls.Add(this.Chose_songs_btn);
            this.save_songs_btn.Controls.Add(this.name_label);
            this.save_songs_btn.Controls.Add(this.user_id_label);
            this.save_songs_btn.Controls.Add(this.logo_pic);
            this.save_songs_btn.Controls.Add(this.panel2);
            this.save_songs_btn.Controls.Add(this.playlist_list);
            this.save_songs_btn.Controls.Add(this.panel1);
            this.save_songs_btn.Controls.Add(this.labeL_picture);
            this.save_songs_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_songs_btn.Location = new System.Drawing.Point(0, 0);
            this.save_songs_btn.Name = "save_songs_btn";
            this.save_songs_btn.Size = new System.Drawing.Size(1139, 592);
            this.save_songs_btn.TabIndex = 0;
            this.save_songs_btn.Paint += new System.Windows.Forms.PaintEventHandler(this.save_songs_btn_Paint);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.delete_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(180, 537);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(162, 52);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "Удалить файл";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.save_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(12, 537);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(162, 52);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Сохранить файлы";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chose_songs_btn
            // 
            this.Chose_songs_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Chose_songs_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Chose_songs_btn.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chose_songs_btn.Location = new System.Drawing.Point(12, 474);
            this.Chose_songs_btn.Name = "Chose_songs_btn";
            this.Chose_songs_btn.Size = new System.Drawing.Size(329, 57);
            this.Chose_songs_btn.TabIndex = 6;
            this.Chose_songs_btn.Text = "Добавить файлы";
            this.Chose_songs_btn.UseVisualStyleBackColor = true;
            this.Chose_songs_btn.Click += new System.EventHandler(this.Chose_songs_btn_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.name_label.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.name_label.Location = new System.Drawing.Point(21, 64);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(99, 24);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "Unnamed";
            // 
            // user_id_label
            // 
            this.user_id_label.AutoSize = true;
            this.user_id_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.user_id_label.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_id_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.user_id_label.Location = new System.Drawing.Point(21, 22);
            this.user_id_label.Name = "user_id_label";
            this.user_id_label.Size = new System.Drawing.Size(60, 24);
            this.user_id_label.TabIndex = 0;
            this.user_id_label.Text = "No ID";
            // 
            // logo_pic
            // 
            this.logo_pic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logo_pic.Location = new System.Drawing.Point(12, 12);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(329, 89);
            this.logo_pic.TabIndex = 2;
            this.logo_pic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ran_button);
            this.panel2.Controls.Add(this.loop_button);
            this.panel2.Controls.Add(this.previous_track);
            this.panel2.Controls.Add(this.next_track);
            this.panel2.Controls.Add(this.label_100);
            this.panel2.Controls.Add(this.pause_play);
            this.panel2.Controls.Add(this.volume_bar);
            this.panel2.Controls.Add(this.time_label);
            this.panel2.Controls.Add(this.song_name_label);
            this.panel2.Controls.Add(this.song_line);
            this.panel2.Location = new System.Drawing.Point(363, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 118);
            this.panel2.TabIndex = 4;
            // 
            // ran_button
            // 
            this.ran_button.BackColor = System.Drawing.SystemColors.Control;
            this.ran_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ran_button.Image = ((System.Drawing.Image)(resources.GetObject("ran_button.Image")));
            this.ran_button.Location = new System.Drawing.Point(283, 32);
            this.ran_button.Name = "ran_button";
            this.ran_button.Size = new System.Drawing.Size(67, 57);
            this.ran_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ran_button.TabIndex = 18;
            this.ran_button.TabStop = false;
            this.ran_button.Click += new System.EventHandler(this.ran_button_Click);
            // 
            // loop_button
            // 
            this.loop_button.BackColor = System.Drawing.SystemColors.Control;
            this.loop_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loop_button.Image = ((System.Drawing.Image)(resources.GetObject("loop_button.Image")));
            this.loop_button.Location = new System.Drawing.Point(214, 32);
            this.loop_button.Name = "loop_button";
            this.loop_button.Size = new System.Drawing.Size(63, 57);
            this.loop_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loop_button.TabIndex = 17;
            this.loop_button.TabStop = false;
            this.loop_button.Click += new System.EventHandler(this.loop_button_Click);
            // 
            // previous_track
            // 
            this.previous_track.BackColor = System.Drawing.SystemColors.Control;
            this.previous_track.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.previous_track.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_track.Image = ((System.Drawing.Image)(resources.GetObject("previous_track.Image")));
            this.previous_track.Location = new System.Drawing.Point(18, 32);
            this.previous_track.Name = "previous_track";
            this.previous_track.Size = new System.Drawing.Size(54, 57);
            this.previous_track.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previous_track.TabIndex = 15;
            this.previous_track.TabStop = false;
            this.previous_track.Click += new System.EventHandler(this.previous_track_Click);
            this.previous_track.MouseEnter += new System.EventHandler(this.previous_track_MouseEnter);
            this.previous_track.MouseLeave += new System.EventHandler(this.previous_track_MouseLeave);
            // 
            // next_track
            // 
            this.next_track.BackColor = System.Drawing.SystemColors.Control;
            this.next_track.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next_track.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_track.Image = ((System.Drawing.Image)(resources.GetObject("next_track.Image")));
            this.next_track.Location = new System.Drawing.Point(154, 32);
            this.next_track.Name = "next_track";
            this.next_track.Size = new System.Drawing.Size(54, 57);
            this.next_track.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next_track.TabIndex = 14;
            this.next_track.TabStop = false;
            this.next_track.Click += new System.EventHandler(this.next_track_Click);
            this.next_track.MouseEnter += new System.EventHandler(this.next_track_MouseEnter);
            this.next_track.MouseLeave += new System.EventHandler(this.next_track_MouseLeave);
            // 
            // label_100
            // 
            this.label_100.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_100.AutoSize = true;
            this.label_100.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_100.Location = new System.Drawing.Point(714, 68);
            this.label_100.Name = "label_100";
            this.label_100.Size = new System.Drawing.Size(47, 24);
            this.label_100.TabIndex = 8;
            this.label_100.Text = "30%";
            this.label_100.Click += new System.EventHandler(this.label_100_Click);
            // 
            // pause_play
            // 
            this.pause_play.BackColor = System.Drawing.SystemColors.Control;
            this.pause_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pause_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause_play.Image = ((System.Drawing.Image)(resources.GetObject("pause_play.Image")));
            this.pause_play.Location = new System.Drawing.Point(78, 23);
            this.pause_play.Name = "pause_play";
            this.pause_play.Size = new System.Drawing.Size(70, 74);
            this.pause_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pause_play.TabIndex = 13;
            this.pause_play.TabStop = false;
            this.pause_play.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // volume_bar
            // 
            this.volume_bar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volume_bar.LargeChange = 10;
            this.volume_bar.Location = new System.Drawing.Point(546, 66);
            this.volume_bar.Maximum = 100;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volume_bar.Size = new System.Drawing.Size(172, 56);
            this.volume_bar.TabIndex = 6;
            this.volume_bar.Scroll += new System.EventHandler(this.volume_bar_Scroll);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_label.Location = new System.Drawing.Point(364, 67);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(64, 25);
            this.time_label.TabIndex = 10;
            this.time_label.Text = "00:00";
            // 
            // song_name_label
            // 
            this.song_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.song_name_label.AutoSize = true;
            this.song_name_label.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.song_name_label.Location = new System.Drawing.Point(365, 13);
            this.song_name_label.Name = "song_name_label";
            this.song_name_label.Size = new System.Drawing.Size(115, 18);
            this.song_name_label.TabIndex = 9;
            this.song_name_label.Text = "Сейчас играет:";
            this.song_name_label.Click += new System.EventHandler(this.song_name_label_Click);
            // 
            // song_line
            // 
            this.song_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.song_line.Location = new System.Drawing.Point(368, 39);
            this.song_line.Name = "song_line";
            this.song_line.Size = new System.Drawing.Size(396, 21);
            this.song_line.TabIndex = 5;
            this.song_line.MouseDown += new System.Windows.Forms.MouseEventHandler(this.song_line_MouseDown);
            // 
            // playlist_list
            // 
            this.playlist_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playlist_list.Font = new System.Drawing.Font("Montserrat Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlist_list.FormattingEnabled = true;
            this.playlist_list.ItemHeight = 24;
            this.playlist_list.Location = new System.Drawing.Point(12, 107);
            this.playlist_list.Name = "playlist_list";
            this.playlist_list.Size = new System.Drawing.Size(329, 364);
            this.playlist_list.TabIndex = 1;
            this.playlist_list.SelectedIndexChanged += new System.EventHandler(this.playlist_list_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.player);
            this.panel1.Location = new System.Drawing.Point(347, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 687);
            this.panel1.TabIndex = 3;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 3);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(10, 69);
            this.player.TabIndex = 8;
            this.player.Visible = false;
            // 
            // labeL_picture
            // 
            this.labeL_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeL_picture.BackColor = System.Drawing.Color.LightBlue;
            this.labeL_picture.Image = global::misis_mp3_pleer.Properties.Resources.disk_picture;
            this.labeL_picture.Location = new System.Drawing.Point(375, 22);
            this.labeL_picture.Name = "labeL_picture";
            this.labeL_picture.Size = new System.Drawing.Size(761, 446);
            this.labeL_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labeL_picture.TabIndex = 9;
            this.labeL_picture.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 592);
            this.Controls.Add(this.save_songs_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3.Pleer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.ResizeEnd += new System.EventHandler(this.Form_main_ResizeEnd);
            this.save_songs_btn.ResumeLayout(false);
            this.save_songs_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ran_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loop_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labeL_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel save_songs_btn;
        private System.Windows.Forms.Label user_id_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo_pic;
        private System.Windows.Forms.ListBox playlist_list;
        private System.Windows.Forms.TrackBar volume_bar;
        private System.Windows.Forms.ProgressBar song_line;
        private System.Windows.Forms.Label label_100;
        private System.Windows.Forms.Label song_name_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label name_label;
        private PictureBox pause_play;
        private PictureBox previous_track;
        private PictureBox next_track;
        private Button Chose_songs_btn;
        private Button save_button;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private PictureBox loop_button;
        private PictureBox ran_button;
        private Timer timer1;
        private Button delete_button;
        private PictureBox labeL_picture;
    }
}