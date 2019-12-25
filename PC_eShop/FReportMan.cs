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
    public partial class FReportMan : Form
    {
        public FReportMan()
        {
            InitializeComponent();
            updChart();
        }

        // Обновление графика
        private void updChart()
        {
            // Получение данных
            List<ReportMan> reports = ReportMan.getList();

            // Настройка графика
            chartMan.Series.Clear();

            // Добавление серий по производителям
            for (int i = 0; i < reports.Count; i++)
            {
                Series manSer = new Series();

                manSer.ChartArea = chartMan.ChartAreas[0].Name;
                manSer.ChartType = SeriesChartType.Column;
                manSer.Legend = chartMan.Legends[0].Name;
                manSer.LegendText = reports[i].Name;

                manSer.Points.AddXY(i, reports[i].TotalCash);

                chartMan.Series.Add(manSer);
            }
        }

        // Нажата кнопка "Обновить график"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updChart();
        }
    }

    // Класс элемента отчета по производителям
    public class ReportMan
    {
        public string Name;
        public int TotalCash;

        public ReportMan(string Name, int TotalCash)
        {
            this.Name = Name;
            this.TotalCash = TotalCash;
        }

        // Получить список записей
        public static List<ReportMan> getList()
        {
            List<ReportMan> reports = new List<ReportMan>();

            SqlDataReader reader = DataBase.readData(  "SELECT [Manufacturer].[Name], SUM([Goods].[Price]) AS 'Price' " +
                                                       "FROM[Order], [OrderList], [Goods], [Manufacturer] " +
                                                       "WHERE[Order].[ORD_ID] = [OrderList].[ORD_ID] " +
                                                       "AND[OrderList].[G_ID] = [Goods].[G_ID] " +
                                                       "AND[Goods].[MF_ID] = [Manufacturer].[MF_ID] " +
                                                       "GROUP BY[Manufacturer].[Name]");

            while (reader.HasRows && reader.Read())
                reports.Add(new ReportMan(reader.GetString(0), reader.GetInt32(1)));

            reader.Close();

            return reports;
        }
    }
}
