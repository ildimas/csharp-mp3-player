using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace misis_mp3_pleer
{
    public partial class Form_register : Form
    {
        public SQLiteConnection conn { get; private set; }
        public static Form_register instance;

        public Form_register()
        {
            InitializeComponent();
            instance = this; 
        }

        private void Label_top_Click(object sender, EventArgs e)
        {

        }

        private void Button_enter_MouseEnter(object sender, EventArgs e)
        {
            Button_enter.Left -= 5;
            Button_enter.Height += 5;
            Button_enter.Width += 10;
            Button_enter.ForeColor = Color.Black;
        }

        private void Button_enter_MouseLeave(object sender, EventArgs e)
        {
            Button_enter.Left += 5;
            Button_enter.Height -= 5;
            Button_enter.Width -= 10;
            Button_enter.ForeColor = Color.White;
        }

        private void Button_enter_Click(object sender, EventArgs e)
        {
            string login = login_box.Text;
            string password1 = password_box_1.Text;
            string password2 = password_box_2.Text;
            bool value = (password1 == password2);
            if ((value == true) && (password1.Length != 0 && password2.Length != 0))
            {
                Console.WriteLine(login + " " + password1);
                this.sucsess_reg.Visible = true;
                this.mistake_reg.Visible = false;
                this.Update();
                SQLiteCommand CMD = conn.CreateCommand();
                CMD.CommandText = $"insert into passwords_and_users(USER_NAME, PASSWORD) values('{login.ToUpper()}', '{password1.ToUpper()}')";
                CMD.ExecuteNonQuery();
                Console.WriteLine("Данные успешно добавлены!");
                CMD.CommandText = $"select * from passwords_and_users";
                int user_id = 0;
                string user_name = "";
                try
                {
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
                    }
                }
                catch (System.Data.SQLite.SQLiteException)
                {
                    Console.WriteLine("ошибка");

                }
                Thread.Sleep(500);
                this.Hide();
                Form_main main_form = new Form_main();
                //Form_main.instance.variable = 10;
                Form_main.instance.uid_label.Text = $"id: {user_id}";
                Form_main.instance.name_label_p.Text = $"Имя: {user_name}";
                Form_main.instance.user_id_int = user_id;
                main_form.Show();
            }
            else
            {
                Console.WriteLine("Пароли введены неверно!");
                mistake_reg.Visible = true;
                sucsess_reg.Visible = false;
            }
            

            
        }

        private void Form_register_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=database.sqlite3; Version=3");
            conn.Open();
        }

        private void Form_register_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void login_box_MouseEnter(object sender, EventArgs e)
        {
            if (login_box.Text == "Логин:")
            {
                login_box.Text = "";
            }
        }

        private void password_box_1_MouseEnter(object sender, EventArgs e)
        {
            if (password_box_1.Text == "example")
            {
                password_box_1.Text = "";
            }
        }

        private void password_box_2_MouseEnter(object sender, EventArgs e)
        {
            if (password_box_2.Text == "example")
            {
                password_box_2.Text = "";
            }
        }

        private void Form_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
