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

            if (comboYear.Items.Count > 0)
                comboYear.SelectedIndex = 0;
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
                    list.Add( new ReportOrders(i, reader.GetInt32(0)) );

                reader.Close();
            }

            return list;
        }
    }
}
