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
