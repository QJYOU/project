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
        SqlConnection conn;
        SqlCommand cmd;
        string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ee258\Desktop\c#\groupProject\graph\graph\Database.mdf;Integrated Security=True";
        string BeginDate = "";
        string EndDate = "";
        string[] xvalue = { "澱粉", "蛋白質", "脂肪", "1", "2" };
        int[] yvalue = { 5, 18, 45, 17, 2 };

        public Form1()
        {
            InitializeComponent();
            BegindatePicker.Visible = true;
            EnddatePicker.Visible = true;
            piechart.Visible = false;
            linechart.Visible = false;
            conn = new SqlConnection();
            conn.ConnectionString = path;
            conn.Open();
            string sqlstr = "CREATE TABLE [dbo].[data] (col0 numeric identity (1,1) primary key,)";
            cmd = new SqlCommand(sqlstr,conn);
            cmd.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BegindatePicker_ValueChanged(object sender, EventArgs e)
        {
            BeginDate = "";
            BeginDate += BegindatePicker.Value.Year.ToString();
            BeginDate += BegindatePicker.Value.Month.ToString();
            BeginDate += BegindatePicker.Value.Day.ToString();
        }

        private void datePickbutton_Click(object sender, EventArgs e)
        {
            piechart.Visible = true;
            linechart.Visible = true;
            piechart.Series[0]["PieLabelStyle"] = "outside";
            piechart.Series["Series1"].Points.DataBindXY(xvalue, yvalue);
            //chart1.Series[0].LegendText = "#VALX:[#PERCENT{P1}]";
            // chart1.Series[0].Label = "#VALX\n#PERCENT{P1}";
            piechart.Series[0].IsValueShownAsLabel = true;
            linechart.Series[0].Points.DataBindXY(xvalue, yvalue);
        }

        private void EnddatePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDate = "";
            EndDate += EnddatePicker.Value.Year.ToString();
            EndDate += EnddatePicker.Value.Month.ToString();
            EndDate += EnddatePicker.Value.Month.ToString();
        }
    }
}
