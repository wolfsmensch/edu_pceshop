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
    public partial class FDevicesList : Form
    {
        public FDevicesList()
        {
            InitializeComponent();
        }

        // Нажата кнопка "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FAddDevice addDevice = new FAddDevice();
            addDevice.ShowDialog();
        }
    }
}
