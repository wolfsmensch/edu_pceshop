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
    public partial class FReportCat : Form
    {
        public FReportCat()
        {
            InitializeComponent();
            updChart();
        }

        // Обновление графика
        private void updChart()
        {
            // Получение данных
            List<ReportCat> reportCats = ReportCat.getList(dateFrom.Value, dateTo.Value);

            // Настройка графика
            chartCat.Series.Clear();

            // Добавление серий по категориям
            for (int i = 0; i < reportCats.Count; i++)
            {
                // chartCat
                Series catSer = new Series();

                catSer.ChartArea = chartCat.ChartAreas[0].Name;
                catSer.ChartType = SeriesChartType.Column;
                catSer.Legend = chartCat.Legends[0].Name;
                catSer.LegendText = reportCats[i].Name;

                catSer.Points.AddXY(i, reportCats[i].TotalPrice);

                chartCat.Series.Add(catSer);
            }
        }

        /* 
         * Изменен период 
         */
        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            updChart();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            updChart();
        }
    }

    // Класс отчета по категориям
    class ReportCat
    {
        public string Name;
        public int TotalPrice;

        public ReportCat(string Name, int TotalPrice)
        {
            this.Name = Name;
            this.TotalPrice = TotalPrice;
        }

        // Получение списка
        public static List<ReportCat> getList(DateTime from, DateTime to)
        {
            List<ReportCat> cats = new List<ReportCat>();

            SqlDataReader reader = DataBase.readData(  "SELECT [Categories].[Name], SUM([Goods].[Price]) AS 'Price' " +
                                                       "FROM[Order], [OrderList], [Goods], [Categories] " +
                                                       "WHERE[Order].[ORD_ID] = [OrderList].[ORD_ID] " +
                                                       "AND[OrderList].[G_ID] = [Goods].[G_ID] " +
                                                       "AND[Goods].[CAT_ID] = [Categories].[CAT_ID] " +
                                                       "AND[Order].[OrdDate] BETWEEN '"+from.ToShortDateString()+"' AND '"+to.ToShortDateString()+"' " +
                                                       "GROUP BY[Categories].[Name]");

            while (reader.HasRows && reader.Read())
                cats.Add(new ReportCat( reader.GetString(0), reader.GetInt32(1) ));

            reader.Close();

            return cats;
        }
    }
}
