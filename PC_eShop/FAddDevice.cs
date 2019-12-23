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
    public partial class FAddDevice : Form
    {
        private List<DeviceCategory> catList;
        private List<DeviceBrand> brandList;

        public FAddDevice()
        {
            InitializeComponent();

            catList = new List<DeviceCategory>();
            brandList = new List<DeviceBrand>();

            prepareForm();
        }

        // Подготовка формы
        private void prepareForm()
        {
            // Получение списка категорий
            SqlDataReader catReader = DataBase.readData("SELECT [CAT_ID], [Name] FROM [Categories]");
            while(catReader.HasRows && catReader.Read())
                catList.Add( new DeviceCategory(catReader.GetInt32(0), catReader.GetString(1)) );

            catReader.Close();

            // Получение списка производителей
            SqlDataReader manReader = DataBase.readData("SELECT [MF_ID], [Name] FROM [Manufacturer]");
            while (manReader.HasRows && manReader.Read())
                brandList.Add(new DeviceBrand(manReader.GetInt32(0), manReader.GetString(1)));

            manReader.Close();

            // Вывод списков в ComboBox
            comboCat.Items.Clear();
            comboMan.Items.Clear();

            for (int i = 0; i < catList.Count; i++)
                comboCat.Items.Add(catList[i].Name);

            for (int i = 0; i < brandList.Count; i++)
                comboMan.Items.Add(brandList[i].Name);

            comboCat.SelectedIndex = 0;
            comboMan.SelectedIndex = 0;
        }
    }

    // Класс категорий
    public class DeviceCategory
    {
        public int ID;
        public string Name;

        public DeviceCategory(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }

    // Класс производителей
    public class DeviceBrand
    {
        public int ID;
        public string Name;

        public DeviceBrand(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
