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

        int begin_date = 20201213;
        int end_date = 20201218;
        List<string>[] list = new List<string>[6];


        List<string> calories_list = new List<string>();
        List<string> sugar_list = new List<string>();
        List<string> fat_list = new List<string>();
        List<string> carbonhydrate_list = new List<string>();
        List<string> protein_list = new List<string>();
        List<string> date_list = new List<string>();
        int days = 0;

        public Form1()
        {
            InitializeComponent();
            BegindatePicker.Visible = true;
            EnddatePicker.Visible = true;
            piechart.Visible = false;
            calories_Chart.Visible = false;
            
            for(int i=0;i<6;++i)
            {
                list[i] = new List<string>();
            }
        }

        public Form1(string username)
        {
            InitializeComponent();
            BegindatePicker.Visible = true;
            EnddatePicker.Visible = true;
            piechart.Visible = false;
            calories_Chart.Visible = false;
            account = username;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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

            //foreach (string item in list[0])
            //    textBox1.Text += item;
            textBox1.Text+=
            piechart.Visible = true;
            calories_Chart.Visible = true;
            piechart.Series[0]["PieLabelStyle"] = "outside";
            
            piechart.Series[0].IsValueShownAsLabel = true;
            calories_Chart.Series[0].Points.DataBindXY(list[1], list[1]);

        }

        private void EnddatePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDate = EnddatePicker.Value.Year.ToString() + EnddatePicker.Value.Month.ToString()+EnddatePicker.Value.Day.ToString();
            //EndDate += EnddatePicker.Value.Month.ToString();
            //EndDate += EnddatePicker.Value.Month.ToString();
            end_date = int.Parse(EndDate);
                      
        }

        private void Read(int begin,int end)
        {
            d.select(account+"2");
            d.between(begin, end);
            d.work();
            d.connect();
            DataTable dt = d.rd.GetSchemaTable();
            int i=0;
            int j = 0;
            foreach (DataRow row in dt.Rows)
            {
                j = 0;
                foreach (DataColumn column in dt.Columns)
                {
                    if (j == 0) j++;
                    else
                    {
                        list[i].Add(row[column].ToString());
                        textBox1.Text += row[column].ToString() + "\r\n";
                    }
                    

                }
                if (i == 0) ++i;

            }
            d.disconnect();
        }
    }
}
