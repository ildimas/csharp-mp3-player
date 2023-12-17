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
        public int length = 0;
        public int range = 0;
        public Form_main main_form;
        public Form_statistics()
        {
            InitializeComponent();
            chart1.Titles.Add("Статистика количества прослушиваний");

        }
        private void chart_population(int range)
        {
            this.chart1.Series.Clear();
            var songs_list = ((Form_main)main_form).songs_list;
            length = songs_list.Count();
            int rr = range;
            for (int i = range; i < rr + 12; i++)
            {
                try
                {
                    chart1.Series.Add(songs_list[i].SongName);
                    chart1.Series[songs_list[i].SongName].Points.Add(songs_list[i].TimesPlayed);
                }
                catch 
                {
                    Console.WriteLine("Конец списка");
                    break;
                }

            }
        }
        private void Form_statistics_Load(object sender, EventArgs e)
        {
            chart_population(range);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.range <= 0)
            {
                Console.WriteLine("Конец списка -");
            }
            else
            {
                this.range -= 12;
                chart_population(this.range);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (length < range + 12)
            {
                Console.WriteLine("Конец списка +");
            }
            else
            {
                this.range += 12;
                chart_population(this.range);
            }
            Console.WriteLine(range);
        }
    }
}
