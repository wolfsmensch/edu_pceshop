using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PC_eShop
{
    public partial class FOrderDetails : Form
    {
        private Order order;

        public FOrderDetails(Order order)
        {
            InitializeComponent();
            this.order = order;

            showHeader();
            showTable();
        }

        // Формирование заголовка таблицы
        private void showHeader()
        {
            textN.Text = order.ID.ToString();
            textFIO.Text = order.clientName;
            textPhone.Text = order.clientPhone;
        }

        // Вывод данных в таблицу
        private void showTable()
        {
            // Настройка таблицы
            gridDevice.Rows.Clear();

            gridDevice.ColumnCount = 6;

            gridDevice.Columns[0].Name = "ID";
            gridDevice.Columns[1].Name = "Название";
            gridDevice.Columns[2].Name = "Производитель";
            gridDevice.Columns[3].Name = "Категория";
            gridDevice.Columns[4].Name = "Цена";
            gridDevice.Columns[5].Name = "Описание";

            gridDevice.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridDevice.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridDevice.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridDevice.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gridDevice.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridDevice.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            gridDevice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDevice.MultiSelect = false;

            // Вывод данных
            for (int i = 0; i < order.orderList.Count; i++)
            {
                Device device = order.orderList[i];
                string[] rowData = { device.ID.ToString(), device.Name, device.ManName, device.CatName, device.Price.ToString() + " тг.", device.TechDesc };
                gridDevice.Rows.Add(rowData);
            }
        }
    }
}
