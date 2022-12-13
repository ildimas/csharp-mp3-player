using misis_mp3_pleer.Properties;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoPlayerController;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq.Expressions;
using System.IO;

namespace misis_mp3_pleer
{
    public partial class Form_main : Form
    {
        public SQLiteConnection conn { get; private set; }
        public static Form_main instance;
        public Label uid_label;
        public Label name_label_p;
        public int user_id_int;
        private bool isMusicPlaying = false;
        private bool isRandom = false;
        private bool isLoop = false;
        private bool isSongsLoaded = false;
        private List<string> files;
        private List<string> paths;
        /*private string[] load_paths;
        private string[] load_files;*/

        //public int variable;
        public Form_main()
        {
            InitializeComponent();
            instance = this;
            uid_label = user_id_label;
            name_label_p = name_label;
 
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            
            volume_bar.Value = (int) AudioManager.GetMasterVolume();
            label_100.Text = $"{volume_bar.Value}%";
            time_label.Text = "00:00";
            conn = new SQLiteConnection("Data Source=database.sqlite3; Version=3");
            conn.Open();
            Console.WriteLine("соединение с бд установлено");
            SQLiteCommand CMD2 = conn.CreateCommand();
            CMD2.CommandText = $"SELECT DISTINCT * from files_urls";
            try
            {
                //Console.WriteLine(counter);
                paths = new List<string>();
                files = new List<string>();
                SQLiteDataReader SQL = CMD2.ExecuteReader();
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        
                        if ($"{SQL.GetInt32(0)}" == $"{user_id_int}")
                        {
                            
                            Console.WriteLine($"{SQL.GetString(1)}" + " " + $"{SQL.GetString(2)}");                                                          
                            playlist_list.Items.Add($"{SQL.GetString(2)}");
                            files.Add($"{SQL.GetString(2)}");
                            paths.Add($"{SQL.GetString(1)}");
                            
                        }
                    }
                }
                try
                {
                                 
                    Console.WriteLine("Загруженные треки");
                    isSongsLoaded = true;
                    Console.WriteLine($"ТРЕКИ ЗАГРУЖЕНЫ - {isSongsLoaded}");
                                                    
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Загруженные треки отсутсвуют");
                    isSongsLoaded = false;
                    Console.WriteLine($"ТРЕКИ ЗАГРУЖЕНЫ - {isSongsLoaded}");
                }
                
            }
            catch (System.Data.SQLite.SQLiteException)
            {
                Console.WriteLine("ошибка");

            }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isMusicPlaying == false) 
            {
                pause_play.Image = Resources.pause;
                isMusicPlaying = true;
                player.Ctlcontrols.play();
            }
            else
            {
                pause_play.Image = Resources.play_button;
                isMusicPlaying = false;
                player.Ctlcontrols.pause();
            }
            /*try
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying == true)
                {
                    song_name_label.Text = $"Сейчас играет: {player.currentMedia.name}";
                }                  
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("ОШИБКА");
            }*/
            
        }

        private void playlist_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labeL_picture.Image = Resources.disk_picture;
                player.URL = paths[playlist_list.SelectedIndex];
                player.Ctlcontrols.play();
                pause_play.Image = Resources.pause;
                isMusicPlaying = true;
                song_name_label.Text = $"Сейчас играет: {player.currentMedia.name}";
                try
                {
                    var file = TagLib.File.Create(paths[playlist_list.SelectedIndex]);
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    labeL_picture.Image = Image.FromStream(new MemoryStream(bin));
                

                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {
                
            }
            
        }

        private void next_track_MouseEnter(object sender, EventArgs e)
        {
            next_track.Image = Resources.next_song_enter;
           
        }

        private void next_track_MouseLeave(object sender, EventArgs e)
        {
            next_track.Image = Resources.next_song;
           
        }


        private void previous_track_MouseEnter(object sender, EventArgs e)
        {
            previous_track.Image = Resources.next_song_reverse_enter;
        }

        private void previous_track_MouseLeave(object sender, EventArgs e)
        {
            previous_track.Image = Resources.next_song_reverse;
        }

        private void next_track_Click(object sender, EventArgs e)
        {
            if (isRandom == false)
            {
                if (playlist_list.SelectedIndex < playlist_list.Items.Count - 1)
                {
                    playlist_list.SelectedIndex = playlist_list.SelectedIndex + 1;
                }
            }
            else
            {
               Random rnd = new Random();
                int index_of_song = rnd.Next(0, playlist_list.Items.Count);
                playlist_list.SelectedIndex = index_of_song;
            }
            var name = player.currentMedia.name;
            song_name_label.Text = $"Сейчас играет: {name}";

        }

        private void previous_track_Click(object sender, EventArgs e)
        {
            if (isRandom == false)
            {
                if (playlist_list.SelectedIndex > 0)
                {
                    playlist_list.SelectedIndex = playlist_list.SelectedIndex - 1;
                }
            }
            else
            {
                Random rnd = new Random();
                int index_of_song = rnd.Next(0, playlist_list.Items.Count);
                playlist_list.SelectedIndex = index_of_song;
            }
            var name = player.currentMedia.name;
            song_name_label.Text = $"Сейчас играет: {name}";

        }

        private void ran_button_Click(object sender, EventArgs e)
        {
            if (isRandom == false)
            {
                ran_button.Image = Resources.ran_song_activate;
                isRandom = true;
            }
            else 
            {
                ran_button.Image = Resources.ran_song;
                isRandom = false;
            }

        }

        private void loop_button_Click(object sender, EventArgs e)
        {
            if (isLoop == false)
            {
                loop_button.Image = Resources.loop_song_activate;
                isLoop = true;
            }
            else
            {
                loop_button.Image = Resources.loop_song;
                isLoop = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                
                try
                {
                    song_line.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                    song_line.Value = (int)player.Ctlcontrols.currentPosition;
                    if (song_line.Value == song_line.Maximum)
                    {
                        if (isLoop == true)
                        {
                            playlist_list_SelectedIndexChanged(sender, e);
                        }
                        else if ((playlist_list.SelectedIndex == playlist_list.Items.Count - 1) && (isLoop != true))
                        {
                            player.URL = paths[0];
                            playlist_list.SelectedIndex = 0;
                            player.Ctlcontrols.play();
                            pause_play.Image = Resources.pause;
                            isMusicPlaying = true;
                            song_name_label.Text = $"Сейчас играет: {player.currentMedia.name}";
                        }
                        else
                        {
                            next_track_Click(sender, e);
                        }
                    }
                    
                }
                catch (Exception)
                {
                    if (isLoop == true)
                    {
                        playlist_list_SelectedIndexChanged(sender, e);
                    }
                    else if ((playlist_list.SelectedIndex == playlist_list.Items.Count) && (isLoop == false))
                    {                       
                        player.URL = paths[0];
                        playlist_list.SelectedIndex = 0;
                        player.Ctlcontrols.play();
                        pause_play.Image = Resources.pause;
                        isMusicPlaying = true;
                        song_name_label.Text = $"Сейчас играет: {player.currentMedia.name}";
                    }
                    else
                    {
                        next_track_Click(sender, e);
                    }
                    

                }
                


            }
            
        
            try
            {
                time_label.Text = player.Ctlcontrols.currentPositionString;
            }
            catch
            {

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand CMD = conn.CreateCommand();
            CMD.CommandText = "DELETE FROM files_urls";
            CMD.ExecuteNonQuery();
            for (int i = 0; i < playlist_list.Items.Count; i++)
            {
                string URL = (string) playlist_list.Items[i];
                SQLiteCommand CMD2 = conn.CreateCommand(); 
                CMD2.CommandText = $"insert into files_urls(USER_ID, SONG_URL, SHORT_NAME) values('{user_id_int}', '{paths[i]}', '{files[i]}')";
                CMD2.ExecuteNonQuery();
            }

        }

        private void song_name_label_Click(object sender, EventArgs e)
        {

        }

        private void volume_bar_Scroll(object sender, EventArgs e)
        {
            label_100.Text = $"{volume_bar.Value}%";
            VideoPlayerController.AudioManager.SetMasterVolume(volume_bar.Value);
        }

        private void label_100_Click(object sender, EventArgs e)
        {

        }

        private void Form_main_ResizeEnd(object sender, EventArgs e)
        {
            

        }

       

        /*private void playhead_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPlayheadHolded == true)
            {
                Point MouseHook = new Point();
                if (e.Button != MouseButtons.Left)
                    MouseHook = e.Location;
                Point izvr = new Point((Size)playhead_volume.Location - (Size)MouseHook + (Size)e.Location);
                playhead_volume.Location = new Point(izvr.X, playhead_volume.Location.Y);
            }
        }*/

 
        private void song_line_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / song_line.Width;
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            Console.WriteLine("соединение с бд разорвано");
            System.Windows.Forms.Application.ExitThread();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string name_to_remove = files[playlist_list.SelectedIndex];
                string url_to_remove = paths[playlist_list.SelectedIndex];
                files.RemoveAt(playlist_list.SelectedIndex);
                paths.RemoveAt(playlist_list.SelectedIndex);
                playlist_list.Items.RemoveAt(playlist_list.SelectedIndex);
                /*Console.WriteLine(name_to_remove);
                Console.WriteLine(url_to_remove);
                Console.WriteLine(user_id_int);*/
                SQLiteCommand CMD = conn.CreateCommand();
                CMD.CommandText = $"DELETE FROM files_urls WHERE USER_ID = '{user_id_int}' AND SONG_URL = '{url_to_remove}' AND SHORT_NAME = '{name_to_remove}'";
                CMD.ExecuteNonQuery();



                
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine(playlist_list.SelectedIndex + " " + "ошибка");
            }
            
            
            /*SQLiteCommand CMD = conn.CreateCommand();            
            CMD.CommandText = $"select * from files_urls";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                while (SQL.Read())
                {

                    if (($"{SQL.GetString(1)}" == login.ToUpper()) && (password1.ToUpper() == $"{SQL.GetString(2)}"))
                    {
                        user_name = SQL.GetString(1);
                        user_id = SQL.GetInt32(0);
                        Console.WriteLine(user_id);

                    }


                }
            }*/
        }


        private void Chose_songs_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect= true;
            ofd.Filter = "Mp3 Files|*.mp3";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                if (isSongsLoaded = false)
                {
                    var list_ofd = new List<string>(ofd.FileNames);                
                    files = UrlsNormalizer(list_ofd);
                    paths = list_ofd;
                    for (int i = 0; i < files.Count(); i++)
                    {
                        playlist_list.Items.Add(files[i]);
                        Console.WriteLine(files[i]);


                    }
                }
                else
                {
                    try
                    {
                        var list_ofd = new List<string>(ofd.FileNames);
                        playlist_list.Items.Clear();
                        Console.WriteLine("Операция с загруженными песнями");
                        var sub_files = UrlsNormalizer(list_ofd);
                        var sub_paths = list_ofd;
                        Console.WriteLine("файлы соеденяются");
                        files = ConnectLists(files, sub_files);
                        Console.WriteLine("пути соеденяются");
                        paths = ConnectLists(paths, sub_paths);
                        for (int i = 0; i < files.Count(); i++)
                        {
                            playlist_list.Items.Add(files[i]);
                        }
                    }                    
                    catch (System.ArgumentNullException)
                    {
                        var list_ofd = new List<string>(ofd.FileNames);
                        files = UrlsNormalizer(list_ofd);
                        paths = list_ofd;
                        for (int i = 0; i < files.Count(); i++)
                        {
                            playlist_list.Items.Add(files[i]);
                            Console.WriteLine(files[i]);


                        }
                    }
                }
   
             
                
            }
        }
        private void Show(List<string> list)
        {
            string answ = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                answ = answ + " " + list[i];
            }
            Console.WriteLine(answ);
        }
        private List<string> UrlsNormalizer(List<string> array)
        {
            var answ = new List<string>();
            for (int i = 0; i < array.Count(); i++)
            {
                string[] add_string = array[i].Split('\\');
                answ.Add(add_string[add_string.Length - 1]);
            }
            return answ;
        }
        private List<string> ConnectLists(List<string> array1, List<string> array2)
        {
            int len = array1.Count() + array2.Count();
            Console.WriteLine(len);
            var result = new List<string>();
            for (int i = 0; i < array1.Count() ; i++) 
            {
                result.Add(array1[i]);
            }
            for (int a = 0; a < array2.Count(); a++)
            {
                result.Add(array2[a]);
            }
            Show(result);
            return result;
        }

        private void save_songs_btn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
