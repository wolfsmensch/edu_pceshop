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
    public partial class FCatManList : Form
    {
        private string FormMode;
        private string tableName;

        /*
         * FormMode - режим работы формы (CAT/MAN)
         */
        public FCatManList(string FormMode)
        {
            InitializeComponent();

            this.FormMode = FormMode;

            if (FormMode == "CAT")
            {
                btnAdd.Text = "Добавить категорию";
                tableName = "Categories";        
            }
            else
            {
                btnAdd.Text = "Добавить производителя";
                tableName = "Manufacturer";

            }

            this.Text = btnAdd.Text;
            updList();
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
            DataBase.execSql("INSERT INTO [" + tableName + "] (Name) VALUES ('" + textName.Text + "')");

            updList();

            textName.Text = String.Empty;
        }

        // Обновление списка
        private void updList()
        {
            // Настройка компонента DataGridView
            gridRecs.Rows.Clear();

            gridRecs.ColumnCount = 1;
            gridRecs.Columns[0].Name = (FormMode == "CAT") ? "Название категории" : "Наименование производителя";
            gridRecs.Columns[0].Width = 260;

            gridRecs.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            gridRecs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRecs.MultiSelect = false;

            // Получение записей из БД
            SqlDataReader reader = DataBase.readData("SELECT [Name] FROM [" + tableName + "]");

            // Вывод данных
            while(reader.HasRows && reader.Read())
            {
                string[] rowData = { reader.GetString(0) };
                gridRecs.Rows.Add(rowData);
            }

            reader.Close();
        }
    }
}
