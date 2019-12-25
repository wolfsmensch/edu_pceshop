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
    public partial class MainForm : Form
    {
        public List<Order> ordersList;

        public MainForm()
        {
            InitializeComponent();
            ordersList = new List<Order>();

            updOrdersTable();
        }

        // Обновление таблицы заказов
        public void updOrdersTable()
        {
            // Получение списка
            ordersList = Order.getList();

            // Настройка таблицы
            gridOrdersList.Rows.Clear();

            gridOrdersList.ColumnCount = 5;

            gridOrdersList.Columns[0].Name = "№";
            gridOrdersList.Columns[1].Name = "Имя клиента";
            gridOrdersList.Columns[2].Name = "Телефон клиента";
            gridOrdersList.Columns[3].Name = "Дата заказа";
            gridOrdersList.Columns[4].Name = "Сумма";

            gridOrdersList.Columns[0].Width = 50;
            gridOrdersList.Columns[1].Width = 250;
            gridOrdersList.Columns[3].Width = 150;

            gridOrdersList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridOrdersList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridOrdersList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridOrdersList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gridOrdersList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridOrdersList.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridOrdersList.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridOrdersList.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridOrdersList.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            gridOrdersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOrdersList.MultiSelect = false;

            // Вывод строк таблицы
            for (int i = 0; i < ordersList.Count; i++)
            {
                Order order = ordersList[i];
                string[] rowData = { order.ID.ToString(), order.clientName, order.clientPhone, order.dateCreate.ToLongDateString(), order.totalPrice.ToString() + " тг." };

                gridOrdersList.Rows.Add(rowData);
            }
        }

        // Кнопка "Добавить заказ"
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FAddOrder addOrder = new FAddOrder();
            addOrder.ShowDialog();
        }

        // Меню: Комплектующие -> Категории
        private void категорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCatManList catForm = new FCatManList("CAT");
            catForm.ShowDialog();
        }

        // Меню: Комплектующие -> Производители
        private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCatManList manForm = new FCatManList("MAN");
            manForm.ShowDialog();
        }

        // Меню: Комплектующие -> Список комплектующих
        private void списокКомплектующихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDevicesList devicesList = new FDevicesList();
            devicesList.ShowDialog();
        }

        // Нажата кнопка: Обновить список
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updOrdersTable();
        }

        // Совершен двойной клик по таблице
        private void gridOrdersList_DoubleClick(object sender, EventArgs e)
        {
            if ( ( ordersList.Count > 0 ) && ( gridOrdersList.SelectedRows.Count > 0 ) )
            {
                FOrderDetails orderDetails = new FOrderDetails(ordersList[gridOrdersList.SelectedRows[0].Index]);
                orderDetails.Show();
            }
        }

        // Пункт меню: Отчет -> Отчет по категориям
        private void заказыПоКатегориямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FReportCat reportCat = new FReportCat();
            reportCat.Show();
        }
    }
}
