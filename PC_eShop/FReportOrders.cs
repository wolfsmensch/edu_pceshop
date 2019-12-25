using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace PC_eShop
{
    public partial class FReportOrders : Form
    {
        public FReportOrders()
        {
            InitializeComponent();
            updChart();
        }

        // Обновление графика
        private void updChart()
        {
            // Получение данных
            int year;
            if ( !Int32.TryParse(textYear.Text, out year) || ( textYear.Text.Length != 4 ) )
            {
                MessageBox.Show("Неправильно введен год.\nПример: 2020", "Неправильно введены данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ReportOrders> reports = ReportOrders.getList(year);

            // Заполнение графика
            chartCash.Series[0].Points.Clear();

            for (int i = 0; i < reports.Count; i++)
                chartCash.Series[0].Points.AddXY(reports[i].monthNum, reports[i].TotalCash);
        }

        // Нажата кнопка "Обновить график"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updChart();
        }
    }

    // Класс фин. отчета
    public class ReportOrders
    {
        public int monthNum;
        public int TotalCash;

        public ReportOrders(int monthNum, int TotalCash)
        {
            this.monthNum = monthNum;
            this.TotalCash = TotalCash;
        }

        public static List<ReportOrders> getList(int year)
        {
            List<ReportOrders> list = new List<ReportOrders>();
            SqlDataReader reader;

            for (int i = 1; i <= 12; i++)
            {
                reader = DataBase.readData("SELECT SUM(TotalPrice) AS 'Sum' FROM [Order] WHERE [OrdDate] BETWEEN '01-"+i.ToString()+"-"+year.ToString()+"' AND '31-"+i.ToString()+ "-" + year.ToString() + "'");

                if ( reader.HasRows && reader.Read() )
                {
                    if (reader.IsDBNull(0))
                        list.Add(new ReportOrders(i, 0));
                    else
                        list.Add(new ReportOrders(i, reader.GetInt32(0)));
                }

                reader.Close();
            }

            return list;
        }
    }
}
