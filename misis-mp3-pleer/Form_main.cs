using misis_mp3_pleer.Properties;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoPlayerController;
using System.Security.Cryptography;
using System.Linq.Expressions;
using System.IO;


namespace misis_mp3_pleer
{
    public partial class Form_main : Form
    {
        public class Song
        {
            public string SongUrl { get; set; }
            public string SongName { get; set; }
            public int TimesPlayed { get; set; }
            public Song(string songUrl, string songName, int timesPlayed = 0)
            {
                SongUrl = songUrl;
                SongName = songName;
                TimesPlayed = timesPlayed;  
            }   
            public Song()
            {
            }
        }
        public SQLiteConnection conn { get; private set; }
        public static Form_main instance;
        public Label uid_label;
        public Label name_label_p;
        public int user_id_int;
        private bool isMusicPlaying = false;
        private bool isRandom = false;
        private bool isLoop = false;
        private bool isSongsLoaded = false;
        public List<Song> songs_list;
        
        public Form_main()
        {
            InitializeComponent();
            instance = this;
            uid_label = user_id_label;
            name_label_p = name_label;
            songs_list= new List<Song>();
 
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Основная форма загружена");
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
                
                SQLiteDataReader SQL = CMD2.ExecuteReader();
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        
                        if ($"{SQL.GetInt32(0)}" == $"{user_id_int}")
                        {
                            
                            Console.WriteLine($"{SQL.GetString(1)}" + " " + $"{SQL.GetString(2)}");
                            Song song = new Song(SQL.GetString(1), SQL.GetString(2), SQL.GetInt32(3));
                            songs_list.Add(song);
                            playlist_list.Items.Add(song.SongName);
                            
                            
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
            Console.WriteLine("Список песен сформирован");
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
            
        }

        private void playlist_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labeL_picture.Image = Resources.disk_picture;
                player.URL = songs_list[playlist_list.SelectedIndex].SongUrl;
                songs_list[playlist_list.SelectedIndex].TimesPlayed += 1;
                player.Ctlcontrols.play();
                pause_play.Image = Resources.pause;
                isMusicPlaying = true;
                song_name_label.Text = $"Сейчас играет: {player.currentMedia.name}";
                try
                {
                    var file = TagLib.File.Create(songs_list[playlist_list.SelectedIndex].SongUrl);
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
                            player.URL = songs_list[0].SongUrl;
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
                        player.URL = songs_list[0].SongUrl;
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


        // 
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Сохранение....");
            SQLiteCommand CMD = conn.CreateCommand();
            CMD.CommandText = "DELETE FROM files_urls";
            CMD.ExecuteNonQuery();
            for (int i = 0; i < playlist_list.Items.Count; i++)
            {
                string URL = (string) playlist_list.Items[i];
                SQLiteCommand CMD2 = conn.CreateCommand(); 
                CMD2.CommandText = $"insert into files_urls(USER_ID, SONG_URL, SHORT_NAME, TIMES_PLAYED) values('{user_id_int}', '{songs_list[i].SongUrl}', '{songs_list[i].SongName}', '{songs_list[i].TimesPlayed}')";
                CMD2.ExecuteNonQuery();
            }

        }

        // Изменение громкости
        private void volume_bar_Scroll(object sender, EventArgs e)
        {
            label_100.Text = $"{volume_bar.Value}%";
            VideoPlayerController.AudioManager.SetMasterVolume(volume_bar.Value);
        }
        // изменение времени проигрывания
        private void song_line_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / song_line.Width;
        }
        // очистка памяти при закрытии формы
        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            Console.WriteLine("соединение с бд разорвано");
            System.Windows.Forms.Application.ExitThread();
        }
        // Удаление песен
        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string name_to_remove = songs_list[playlist_list.SelectedIndex].SongName;
                string url_to_remove = songs_list[playlist_list.SelectedIndex].SongUrl;
                songs_list.RemoveAt(playlist_list.SelectedIndex);
                playlist_list.Items.RemoveAt(playlist_list.SelectedIndex);
                SQLiteCommand CMD = conn.CreateCommand();
                CMD.CommandText = $"DELETE FROM files_urls WHERE USER_ID = '{user_id_int}' AND SONG_URL = '{url_to_remove}' AND SHORT_NAME = '{name_to_remove}'";
                CMD.ExecuteNonQuery();     
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine(playlist_list.SelectedIndex + " " + "ошибка");
            }
        }
        // Добавление песен
        private void Chose_songs_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect= true;
            ofd.Filter = "Mp3 Files|*.mp3";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                if (isSongsLoaded == false)
                {
                    var list_ofd = new List<string>(ofd.FileNames);
                    for (int i = 0; i < list_ofd.Count(); i++)
                    {
                        Song song = new Song(list_ofd[i], UrlNormalizer(list_ofd[i]));
                        songs_list.Add(song);
                        playlist_list.Items.Add(songs_list[i].SongName);


                    }
                }
                else
                {
                    try
                    {
                        var list_ofd = new List<string>(ofd.FileNames);
                        playlist_list.Items.Clear();
                        Console.WriteLine("Операция с загруженными песнями");
                        List<Song> sub_song_list = new List<Song>();
                        for (int i = 0; i < list_ofd.Count(); i++)
                        {
                            Song sub_song = new Song(list_ofd[i], UrlNormalizer(list_ofd[i]));
                            sub_song_list.Add(sub_song);
                        }
                        Console.WriteLine("Cоединение списков");
                        songs_list = ConnectLists(sub_song_list, songs_list);
                        for (int i = 0; i < songs_list.Count(); i++)
                        {
                            playlist_list.Items.Add(songs_list[i].SongName);
                        }
                    }                    
                    catch (System.ArgumentNullException)
                    {
                        var list_ofd = new List<string>(ofd.FileNames);
                        for (int i = 0; i < list_ofd.Count(); i++)
                        {
                            Song sub_song = new Song(list_ofd[i], UrlNormalizer(list_ofd[i]));
                            //songs_list.Add(sub_song);
                            songs_list.Clear();
                            Console.WriteLine("dasdad");

                            playlist_list.Items.Add(songs_list[i].SongName);
                        }
                    }
                }
   
             
                
            }
        }
        // Технические функции
        private string mp3Normalizer(string stroke) 
        {
            return stroke.Substring(0, stroke.Length - 3);
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
        private string UrlNormalizer(string stroke)
        {
            var answ = new List<string>();
            string[] add_stroke = stroke.Split('\\');
            return mp3Normalizer(add_stroke[add_stroke.Length - 1]);
        }
        private List<T> ConnectLists<T>(List<T> array1, List<T> array2)
        {
            int len = array1.Count() + array2.Count();
            Console.WriteLine(len);
            var result = new List<T>();
            for (int i = 0; i < array1.Count; i++)
            {
                result.Add(array1[i]);
            }
            for (int a = 0; a < array2.Count; a++)
            {
                result.Add(array2[a]);
            }
            return result;
        }

        private void StatButton_Click(object sender, EventArgs e)
        {
            Form_statistics stat_form = new Form_statistics();
            stat_form.main_form = this;
            stat_form.Show();
        }
    }
}
