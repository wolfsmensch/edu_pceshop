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

        public FAddOrderDevice(FAddOrder parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
        }
    }
}
