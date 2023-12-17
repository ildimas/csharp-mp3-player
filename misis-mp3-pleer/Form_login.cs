using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using System.IO;


namespace misis_mp3_pleer
{
    public partial class Form_login : Form
    {
        // Инициализация системных переменных
        public static Form_login instance;
        public static bool isFirstDB = true;
        private SQLiteConnection conn;
        
        // Инициализация формы логина пользователя
        public Form_login()       
        {
            InitializeComponent();
            instance = this;
        }
        
        // Функция выполняемая при загрузке формы 
        public void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Форма логина загружена");
            // Проверка на наличие файла  sqlite3, и его создание если файл отсутствует 
            if (File.Exists("./database.sqlite3"))
            {
                // Подключение к базе данных (уже существующей)
                conn = new SQLiteConnection("Data Source=database.sqlite3; Version=3");
                conn.Open();
                isFirstDB = false;
                Console.WriteLine("файл существует");
                
            }
            else
            {
                // Подключение к базе данных и разметка таблци в ней с помощью SQL запросов 
                SQLiteConnection.CreateFile("database.sqlite3");
                conn = new SQLiteConnection("Data Source=database.sqlite3; Version=3");
                conn.Open();
                SQLiteCommand CMD = conn.CreateCommand();
                CMD.CommandText = "CREATE TABLE passwords_and_users(id INTEGER PRIMARY KEY, USER_NAME VARCHAR, PASSWORD VARCHAR)";
                CMD.ExecuteNonQuery();
                SQLiteCommand CMD2 = conn.CreateCommand();
                CMD2.CommandText = "CREATE TABLE files_urls (USER_ID INT, SONG_URL VARCHAR, SHORT_NAME VARCHAR DEFAULT NONE, TIMES_PLAYED INT DEFAULT 0)";
                CMD2.ExecuteNonQuery();


                isFirstDB = true;
                Console.WriteLine("файл не существует");
             
            }
            
        
        }
        //! Изменение формата кнопки при наведении курсора мыши на нее 
        private void Button_enter_MouseEnter(object sender, EventArgs e)
        {
            Button_enter.Left -= 5;
            Button_enter.Height += 10;
            Button_enter.Width += 10;
            Button_enter.ForeColor = Color.Black;
        }

        private void Button_enter_MouseLeave(object sender, EventArgs e)
        {
            Button_enter.Left += 5;
            Button_enter.Height -= 10;
            Button_enter.Width -= 10;
            Button_enter.ForeColor = Color.White;
        }

        private void button_registration_MouseEnter(object sender, EventArgs e)
        {
            button_registration.Left -= 5;
            button_registration.Height += 10;
            button_registration.Width += 10;
            button_registration.ForeColor = Color.Black;
        }

        private void button_registration_MouseLeave(object sender, EventArgs e)
        {
            button_registration.Left += 5;
            button_registration.Height -= 10;
            button_registration.Width -= 10;
            button_registration.ForeColor = Color.White;
        }
        //!
        
        //Функционал кнопки авторизации
        // Логин пользователя или выдача контролируемой ошибки если пользователь не найден
        private void Button_enter_Click(object sender, EventArgs e)
        {
            String user_login = login_box.Text;
            String user_password = password_box.Text;
            bool is_exist = false;
            SQLiteCommand CMD = conn.CreateCommand();
            CMD.CommandText = $"select * from passwords_and_users";
            int id = 0;
            string name = "";
            try
            {
                SQLiteDataReader SQL = CMD.ExecuteReader();
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        
                        if (($"{SQL.GetString(1)}" == user_login.ToUpper()) && (user_password.ToUpper() == $"{SQL.GetString(2)}"))
         
                        {
                            id = SQL.GetInt32(0);
                            name = SQL.GetString(1);
                            is_exist = true;
                            

                        }
                             
                        
                    }
                }
            }
            catch (System.Data.SQLite.SQLiteException)
            {
                Console.WriteLine("ошибка");
            // Вывод статуса логина пользователя ошибка/успех
            }
            if (is_exist == true) {
                this.sucsess_reg.Visible = true;
                Console.WriteLine("Успешный вход");
                this.Update();
                Thread.Sleep(500);
                this.Hide();
                Form_main main_form = new Form_main();
                Form_main.instance.uid_label.Text = $"id: {id}";
                Form_main.instance.name_label_p.Text = $"Имя: {name}";
                Form_main.instance.user_id_int = id;
                main_form.Show();
            }
            else
            {
                this.mistake_reg.Visible = true;
                this.Update();
                Thread.Sleep(500);
                this.mistake_reg.Visible = false;
            }
            
            
            
        }
        // Функция останавливающая форму логина и запускающая форму регистрации
        private void button_registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_register reg_form = new Form_register();
            reg_form.Show();
        }
        // Функция очищающая системные переменные при закрытии формы 
        private void Form_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            conn.Close();
            System.Windows.Forms.Application.ExitThread();
        }
        // Функция отвечающая за исчезновение dummy текста при наведении курсора на поле логина 
        private void login_box_MouseEnter(object sender, EventArgs e)
        {
            if (login_box.Text == "Логин:")
            {
                login_box.Text = "";
            }
            

        }
        // Функция отвечающая за исчезновение dummy текста при наведении курсора на поле пароля
        private void password_box_MouseEnter(object sender, EventArgs e)
        {
            if (password_box.Text == "example")
            {
                password_box.Text = "";
            }
        }
    }
}
