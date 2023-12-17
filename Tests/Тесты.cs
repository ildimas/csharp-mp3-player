using Microsoft.VisualStudio.TestTools.UnitTesting;
using misis_mp3_pleer;
using System;
using System.IO;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SQLite;

namespace Tests
{
    [TestClass]
    public class Тесты
    {
        [TestMethod]
        public void bd_creation_test()
        {
            misis_mp3_pleer.Form_login lf = new misis_mp3_pleer.Form_login();
            Console.WriteLine("Запуск теста на наличие файла бд");
            Assert.AreEqual(File.Exists("./database.sqlite3"), true);
        }
    }
}
