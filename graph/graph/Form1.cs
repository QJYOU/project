using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace graph
{
    public partial class Form1 : Form
    {
        string account = "qq";
        string BeginDate = "";
        string EndDate = "";
        data d = new data();

        int begin_date = 0;
        int end_date = 0;
        List<string>[] list = new List<string>[6];
        /* list[0] = date
         * list[1]= calories
         * list[2]=carbonhydrate
         * list[3]=protein
         * list[4]=fat
         * list[5]=sugar
         */
        public Form1()
        {
            InitializeComponent();        
        }

        public Form1(string username)
        {
            InitializeComponent();
            account = username;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i)
            {
                list[i] = new List<string>();
            }
            BegindatePicker.Visible = true;
            EnddatePicker.Visible = true;
            piechart.Visible = false;
            calories_Chart.Visible = false;
            datePickbutton.Enabled = false;

            BeginDate=BegindatePicker.Value.Year.ToString() + BegindatePicker.Value.Month.ToString() + BegindatePicker.Value.Day.ToString();
            begin_date = int.Parse(BeginDate);
            EndDate = EnddatePicker.Value.Year.ToString() + EnddatePicker.Value.Month.ToString() + EnddatePicker.Value.Day.ToString();
            end_date = int.Parse(EndDate);
        }

        private void BegindatePicker_ValueChanged(object sender, EventArgs e)
        {
            BeginDate = BegindatePicker.Value.Year.ToString() + BegindatePicker.Value.Month.ToString()+ BegindatePicker.Value.Day.ToString();
            begin_date = int.Parse(BeginDate);
           // BeginDate += BegindatePicker.Value.Month.ToString();
            //BeginDate += BegindatePicker.Value.Day.ToString();
        }

        private void datePickbutton_Click(object sender, EventArgs e)
        {
            Read(begin_date,end_date); 
            //piechart
            if (comboBox1.SelectedIndex == 5)
            {
                piechart.Series[0]["PieLabelStyle"] = "inside";
                piechart.Series[0].IsValueShownAsLabel = true;
                piechart.Visible = true;
                double calories_avg = 0;
                double carbon_avg = 0;
                double protein_avg = 0;
                double fat_avg = 0;
                double sugar_avg = 0;
                calories_Chart.Visible = false;

                for (int i = 0; i < list[0].Count; ++i)
                {
                    calories_avg += (Convert.ToDouble(list[1][i])) / (double)list[0].Count;
                    carbon_avg += Convert.ToDouble(list[2][i]) / (double)list[0].Count;
                    protein_avg += Convert.ToDouble(list[3][i]) / (double)list[0].Count;
                    fat_avg += Convert.ToDouble(list[4][i]) / (double)list[0].Count;
                    sugar_avg += Convert.ToDouble(list[5][i]) / (double)list[0].Count;
                }

                double[] avg = { calories_avg, carbon_avg, protein_avg, fat_avg, sugar_avg };
                string[] ingredient = { "calories", "carbonhydrate", "protein", "fat", "sugar" };
                piechart.Series[0].Points.DataBindXY(ingredient, avg);
            }
            //linechart
            if (comboBox1.SelectedIndex == 0)
            {
                calories_Chart.Visible = true;
                calories_Chart.Series[0].Points.DataBindXY(list[0], list[1]);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                calories_Chart.Visible = true;
                calories_Chart.Series[0].Points.DataBindXY(list[0], list[2]);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                calories_Chart.Visible = true;
                calories_Chart.Series[0].Points.DataBindXY(list[0], list[3]);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                calories_Chart.Visible = true;
                calories_Chart.Series[0].Points.DataBindXY(list[0], list[4]);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                calories_Chart.Visible = true;
                calories_Chart.Series[0].Points.DataBindXY(list[0], list[5]);
            }

            //clear list
            for(int i=0;i<6;++i)
            {
                list[i].Clear();
            }
        }

        private void EnddatePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDate = EnddatePicker.Value.Year.ToString() + EnddatePicker.Value.Month.ToString()+EnddatePicker.Value.Day.ToString();
            end_date = int.Parse(EndDate);                  
        }

        private void Read(int begin,int end)
        {          
            d.select(account+"2");
            d.between(begin, end);
            d.work();
            d.con();
            do
            {
                while (d.rd.Read())
                {
                    for (int i = 0; i < 6; i++)
                    {
                        list[i].Add(d.rd[i].ToString());
                    }
                }
            } while (d.next());       
            d.disconnect();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            datePickbutton.Enabled = true;
        }
    }
}
