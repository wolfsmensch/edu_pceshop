﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PC_eShop
{
    public partial class FAddOrder : Form
    {
        public FAddOrder()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            FAddOrderDevice addOrderDevice = new FAddOrderDevice(this);
            addOrderDevice.ShowDialog();
        }
    }
}
