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
    public partial class FDevicesList : Form
    {
        public FDevicesList()
        {
            InitializeComponent();
            updList();
        }

        // Нажата кнопка "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FAddDevice addDevice = new FAddDevice(updList);
            addDevice.ShowDialog();
        }

        // Обновление списка
        private void updList()
        {
            // Настройка таблицы
            gridDevice.Rows.Clear();

            gridDevice.ColumnCount = 7;

            gridDevice.Columns[0].Name = "ID";
            gridDevice.Columns[1].Name = "Название";
            gridDevice.Columns[2].Name = "Производитель";
            gridDevice.Columns[3].Name = "Категория";
            gridDevice.Columns[4].Name = "Кол-во на складе";
            gridDevice.Columns[5].Name = "Цена";
            gridDevice.Columns[6].Name = "Описание";

            gridDevice.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridDevice.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridDevice.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridDevice.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridDevice.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gridDevice.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            gridDevice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDevice.MultiSelect = false;

            // Получение данных из БД
            SqlDataReader reader = DataBase.readData("SELECT [Goods].[G_ID], [Goods].[Name], [Categories].[Name], [Manufacturer].[Name], [Goods].[Price], [Goods].[StockQuant], [Goods].[TechDesc] " +
                                                     "FROM[Goods], [Manufacturer], [Categories] " +
                                                     "WHERE[Goods].[MF_ID] = [Manufacturer].[MF_ID] " +
                                                     "AND[Goods].[CAT_ID] = [Categories].[CAT_ID]");

            while(reader.HasRows && reader.Read())
            {
                string[] rowData = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(3), reader.GetString(2),
                            reader.GetInt32(5).ToString(), reader.GetInt32(4).ToString(), reader.GetString(6)};
                gridDevice.Rows.Add(rowData);
            }

            reader.Close();
        }
    }
}
