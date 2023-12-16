using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace misis_mp3_pleer
{
    public partial class Form_statistics : Form
    {
        public Form_main main_form;
        public Form_statistics()
        {
            InitializeComponent();
            
        }

        private void Form_statistics_Load(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            chart1.Titles.Add("Статистика количества прослушиваний");
            var songs_list = ((Form_main)main_form).songs_list;
            for (int i = 0; i < songs_list.Count(); i++)
            {
                chart1.Series.Add(songs_list[i].SongName);
                chart1.Series[songs_list[i].SongName].Points.Add(songs_list[i].TimesPlayed);
            }
            
        
        }
    }
}
