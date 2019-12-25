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
        }

        // Формирование заголовка таблицы
        private void showHeader()
        {
            textN.Text = order.ID.ToString();
            textFIO.Text = order.clientName;
            textPhone.Text = order.clientPhone;
        }
    }
}
