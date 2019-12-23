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
    public partial class FCatManList : Form
    {
        private string FormMode;

        /*
         * FormMode - режим работы формы (CAT/MAN)
         */
        public FCatManList(string FormMode)
        {
            InitializeComponent();

            this.FormMode = FormMode;

            if (FormMode == "CAT")
                btnAdd.Text = "Добавить категорию";
            else
                btnAdd.Text = "Добавить производителя";

            this.Text = btnAdd.Text;
        }
    }
}
