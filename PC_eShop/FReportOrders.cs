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
    public partial class FReportOrders : Form
    {
        public FReportOrders()
        {
            InitializeComponent();

            if (comboYear.Items.Count > 0)
                comboYear.SelectedIndex = 0;
        }
    }
}
