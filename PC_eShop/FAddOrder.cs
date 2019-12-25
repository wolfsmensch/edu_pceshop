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
        private List<Device> devicesList = null;

        public FAddOrder()
        {
            InitializeComponent();

            devicesList = new List<Device>();
            updDeviceTable();
        }

        // Нажата кнопка "Добавить комплектующие"
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            FAddOrderDevice addOrderDevice = new FAddOrderDevice(this);
            addOrderDevice.ShowDialog();
        }

        // Обновление таблицы комплектующих
        private void updDeviceTable()
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

            // Вывод данных в таблицу
            for (int i = 0; i < devicesList.Count; i++)
            {
                Device devRec = devicesList[i];
                string[] rowData = { devRec.ID.ToString(), devRec.Name, devRec.ManName, devRec.CatName, devRec.StockQuant.ToString() + " шт.", devRec.Price.ToString()+" тг.", devRec.TechDesc };

                gridDevice.Rows.Add(rowData);
            }

            // Подсчет суммы заказа
            calcOrderPrice();
        }

        // Проверка: устройство есть в заказе
        public bool isCategoryInOrder(int catID)
        {
            for (int i = 0; i < devicesList.Count; i++)
            {
                if (devicesList[i].CatID == catID)
                    return true;
            }

            return false;
        }

        // Добавление устройства в заказ
        public void addDeviceToOrder(Device device)
        {
            if (isCategoryInOrder(device.CatID))
            {
                MessageBox.Show("Устройство из категории " + device.CatName + " уже имеется в заказе", "Нельзя добавить устройство в заказ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            devicesList.Add(device);
            updDeviceTable();
        }

        // Подсчет общей стоимости заказа
        private void calcOrderPrice()
        {
            int sum = 0;

            if (devicesList.Count > 0)
            {
                for (int i = 0; i < devicesList.Count; i++)
                    sum += devicesList[i].Price;
            }

            textSum.Text = sum.ToString() + " тг.";
        }

        // Нажата кнопка: Добавить заказ
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверка полей и таблицы
            if ( ( textFIO.Text.Length <= 0 ) || ( textPhone.Text.Length <= 0 ) )
            {
                MessageBox.Show("Не заполнена информация о клиенте", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ( devicesList.Count <= 0 )
            {
                MessageBox.Show("Отсутствует состав заказа (нет компонентов)", "Нет состава заказа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Сохранение заказа
            Order order = new Order();

            order.clientName = textFIO.Text;
            order.clientPhone = textPhone.Text;

            order.dateCreate = dateOrder.Value;

            order.orderList = devicesList;

            order.addToDB();

            MessageBox.Show("Заказ сохранен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
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
        public static List<Device> getByCatID(int catID)
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

    // Класс заказов
    public class Order
    {
        public int ID;

        public DateTime dateCreate;

        public string clientName;
        public string clientPhone;

        public int totalPrice;

        public List<Device> orderList;
        
        // Добавление заказа в БД
        public void addToDB()
        {
            // Создание записи заказа
            DataBase.execSql("INSERT INTO [Order] (OrdDate, ClientName, ClientPhone, TotalPrice) " +
                             "VALUES('"+dateCreate.ToShortDateString()+ "', '"+clientName+"', '"+clientPhone+"', "+getTotalPrice().ToString()+")");

            // Получение ID нового заказа
            SqlDataReader reader = DataBase.readData("SELECT MAX(ORD_ID) AS 'ID' FROM [Order]");
            if ( reader.HasRows && reader.Read() )
            {
                ID = reader.GetInt32(0);
                reader.Close();
            }

            // Связывание устройств с заказом
            for (int i = 0; i < orderList.Count; i++)
                attachDeviceAndOrder(orderList[i].ID);
        }

        // Связывание устройства с заказом
        private void attachDeviceAndOrder(int deviceID)
        {
            // Связывание
            DataBase.execSql("INSERT INTO [OrderList] (ORD_ID, G_ID) VALUES (" + ID.ToString() + ", " + deviceID.ToString() + ")");

            // Вычитание кол-ва устройства на складе
            SqlDataReader reader = DataBase.readData("SELECT [StockQuant] FROM [Goods] WHERE [G_ID] = " + deviceID.ToString());
            if ( reader.HasRows && reader.Read() )
            {
                int count = reader.GetInt32(0) - 1;
                reader.Close();

                DataBase.execSql("UPDATE [Goods] SET [StockQuant] = "+count.ToString()+" WHERE [G_ID] = " + deviceID.ToString());
            }
        }

        // Получение итоговой цены заказа
        public int getTotalPrice()
        {
            int sum = 0;

            if (orderList.Count > 0)
            {
                for (int i = 0; i < orderList.Count; i++)
                    sum += orderList[i].Price;
            }

            return sum;
        }
    }
}
