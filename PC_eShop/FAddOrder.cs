using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace PC_eShop
{
    public partial class FAddOrder : Form
    {
        public FAddOrder()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            FAddOrderDevice addOrderDevice = new FAddOrderDevice(this);
            addOrderDevice.ShowDialog();
        }
    }

    // Класс комплектующих
    public class Device
    {
        public int ID;

        public string Name;

        public int CatID;
        public int ManID;
        public string CatName;
        public string ManName;

        public int StockQuant;
        public int Price;

        public string TechDesc;

        // Получение списка комплектующих по ID категории
        public List<Device> getByCatID(int catID)
        {
            List<Device> list = new List<Device>();

            SqlDataReader reader = DataBase.readData(  "SELECT [Goods].[G_ID], [Goods].[Name], [Categories].[Name], [Categories].[CAT_ID], [Manufacturer].[Name], [Manufacturer].[MF_ID], [Goods].[Price], [Goods].[StockQuant], [Goods].[TechDesc] " +
                                                       "FROM[Goods], [Manufacturer], [Categories] " +
                                                       "WHERE[Goods].[MF_ID] = [Manufacturer].[MF_ID] " +
                                                       "AND[Goods].[CAT_ID] = [Categories].[CAT_ID] " +
                                                       "AND[Goods].[CAT_ID] = " + catID.ToString());

            while (reader.HasRows && reader.Read())
            {
                Device device = new Device();

                device.ID = reader.GetInt32(0);
                device.Name = reader.GetString(1);

                device.CatID = reader.GetInt32(3);
                device.ManID = reader.GetInt32(5);

                device.CatName = reader.GetString(2);
                device.ManName = reader.GetString(4);

                device.StockQuant = reader.GetInt32(7);
                device.Price = reader.GetInt32(6);

                device.TechDesc = reader.GetString(8);

                list.Add(device);
            }

            reader.Close();

            return list;
        }
    }
}
