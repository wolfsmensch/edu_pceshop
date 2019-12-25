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
    public partial class FAddOrderDevice : Form
    {
        private FAddOrder parentForm;
        private List<DeviceCategory> catList;
        private List<Device> devList;

        public FAddOrderDevice(FAddOrder parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            catList = new List<DeviceCategory>();
            devList = new List<Device>();

            updCatList();
            updDevList();
        }

        // Обновление списка категорий
        private void updCatList()
        {
            catList = DeviceCategory.getList();

            comboCat.Items.Clear();

            for (int i = 0; i < catList.Count; i++)
                comboCat.Items.Add(catList[i].Name);

            comboCat.SelectedIndex = 0;
        }

        // Обновление списка компонентов
        private void updDevList()
        {
            devList = Device.getByCatID(catList[comboCat.SelectedIndex].ID);

            listDevice.Items.Clear();

            if ( devList.Count > 0 )
            {
                for (int i = 0; i < devList.Count; i++)
                    listDevice.Items.Add(devList[i].ManName + " " + devList[i].Name);

                listDevice.SelectedIndex = 0;
            }
        }

        // В выпадающем меню изменена категория
        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            updDevList();
        }

        // Нажата кнопка: Добавить в заказ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( (devList.Count > 0) && (listDevice.SelectedIndex >= 0) )
                parentForm.addDeviceToOrder(devList[listDevice.SelectedIndex]);
        }
    }
}
