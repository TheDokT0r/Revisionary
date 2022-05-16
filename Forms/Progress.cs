using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace Revisionary
{
    public partial class Progress : Form
    {
        CardsSet set;
        dynamic setData;
        Chart chart;
        
        public Progress(CardsSet set)
        {
            InitializeComponent();

            this.set = set;
            setData = MannageStuts.GetDataOfSpecificSet(set);

            lbl_title.Text = "Your progress in " + set.title;
            //center lbl_titile
            lbl_title.Location = new Point(this.Width / 2 - lbl_title.Width / 2, lbl_title.Location.Y);

            setChart();
        }

        void setChart()
        {
            int questionsAmount = setData.questionsAmount;

            var dates = new List<string>();
            foreach(var item in setData.dates)
            {
                dates.Add(Convert.ToString(item));
            }
            
            int[] records = setData["records"].ToObject<int[]>();
            List<int> pressantage = new List<int>();
            for (int i = 0; i < records.Length; i++)
            {
                pressantage.Add(records[i] * 100 / questionsAmount);
            }

            Refresh();

            //Create a chart of the records and dates arrays
            chart = new Chart();
            chart.Name = set.title;
            chart.BackColor = SystemColors.Window;
            chart.ChartAreas.Add("ChartArea1");
            chart.Series.Add("records");
            chart.Series["records"].ChartType = SeriesChartType.Spline;
            chart.Series["records"].Points.DataBindXY(dates, pressantage);
            chart.Series["records"].SetDefault(true);
            chart.Series["records"].Enabled = true;
            chart.ChartAreas["ChartArea1"].BackColor = SystemColors.ControlLight;
            chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisX.MajorTickMark.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.MajorTickMark.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Enabled = false;

            //Resize the chart to 70% of the form
            chart.Width = (int)(Width * 0.6);
            chart.Height = (int)(Height * 0.6);
            chart.Location = new Point((int)(Width * 0.30), (int)(Height * 0.1));


            //Make the color of chart background white and the data black and the borders of the chart black
            chart.ChartAreas["ChartArea1"].BackColor = SystemColors.Window;
            chart.Series["records"].Color = SystemColors.WindowText;
            chart.Series["records"].BorderColor = SystemColors.WindowText;
            chart.Series["records"].BorderWidth = 2;


            //Show the data on the chart
            chart.Series["records"].IsValueShownAsLabel = true;
            chart.Series["records"].LabelForeColor = SystemColors.WindowText;
            chart.Series["records"].LabelFormat = "0";

            //Show data of the y and axis lines
            chart.ChartAreas["ChartArea1"].AxisX.IsLabelAutoFit = true;
            chart.ChartAreas["ChartArea1"].AxisY.IsLabelAutoFit = true;
            //Show chart title
            chart.Titles.Add(set.title);

            //Show y axis and x axis titles
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Game";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "% of the set answered correctly";


            //Add the chart to the form
            Controls.Add(chart);
            Refresh();
        }


        void setLabels()
        {
            int perfectGames = 0;
            foreach(var game in setData.records)
            {
                if(game >= setData.questionsAmount)
                {
                    perfectGames++;
                }
            }

            lbl_gamesPlayed.Text = "Games Played: " + setData.records.Count;
            lbl_perfectGames.Text = "Perfect Games: " + perfectGames;
            lbl_timePlayed.Text = "Time played: " + setTimePlayedStr(Convert.ToDouble(setData.time_played)) + " minutes";
        }

        string setTimePlayedStr(double timePlayed)
        {
            string[] splited = timePlayed.ToString().Split(".");

            return splited[0] + "." + splited[1].Substring(0, 2);
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            setLabels();
        }


        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_backToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Game game = new Game(set);
            game.Show();
            Hide();
        }
    }
}
