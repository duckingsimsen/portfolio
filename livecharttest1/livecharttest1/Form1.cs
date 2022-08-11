using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Controls;
using System.Windows.Forms.Integration;

namespace livecharttest1
{
    public partial class Form1 : Form
    {
        public string[] temp = new string[8] { "20", "23", "25", "27", "20", "23", "25", "27" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            List<double> values = new List<double>();
            for (int i = 0; i < 8; i++)
            {
                values.Add(Convert.ToDouble(temp[i]));
            }

            series.Add(new LineSeries() { Title = "temp", Values = new ChartValues<double>(values), DataLabels = true, Fill = System.Windows.Media.Brushes.Transparent });
            cartesianChart1.Series = series;
        }
    }
}
