using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;

namespace misis_mp3_pleer
{
    internal class Database
    {
        public SQLiteConnection myConnection;
        public Database() 
        {
            myConnection = new SQLiteConnection("Data Sourse=database.sqlite3");
            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                Console.WriteLine("Файл создан");
            }
            else
            {
                Console.WriteLine("Файл уже есуществует");
            }

            
        }
         
    }
}
