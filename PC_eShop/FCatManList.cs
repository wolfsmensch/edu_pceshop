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

        // Кнопка: Добавить ...
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Проверка поля с названием
            if (textName.Text.Length <= 0)
            {
                MessageBox.Show("Заполните поле \"Название\"", "Поле не заполнено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Добавление в БД
            string tableName = String.Empty;
            if (this.FormMode == "CAT")
                tableName = "Categories";
            else
                tableName = "Manufacturer";

            DataBase.execSql("INSERT INTO [" + tableName + "] (Name) VALUES ('" + textName.Text + "')");

            textName.Text = String.Empty;
            MessageBox.Show("Запись добавлена");
        }
    }
}
