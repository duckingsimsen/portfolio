using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            int[] a = new int[8] { 1, 1, 1, 1, 1, 1, 1, 1 };// all 1
            int[] time = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };// time 시간
            int[] temp = new int[8] { 11, 13, 16, 18, 11, 14, 10, 5 }; // temp 기온

            //Init date
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            List<double> values = new List<double>();
            for (int time_ = 0; time_ <= 7; time_++)
            {
                values.Add(temp[time_]);
            }

            series.Add(new LineSeries() { Title = "temp", Values = new ChartValues<double>(values), DataLabels = true, Fill = System.Windows.Media.Brushes.Transparent });
            cartesianChart1.Series = series;
        }
    }
}
