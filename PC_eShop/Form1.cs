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
        public MainForm()
        {
            InitializeComponent();
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
    }
}
