﻿namespace PC_eShop
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.комплектующиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКомплектующихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыПоКатегориямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыПоПроизводителямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыПоМесяцамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridOrdersList = new System.Windows.Forms.DataGridView();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrdersList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.комплектующиеToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // комплектующиеToolStripMenuItem
            // 
            this.комплектующиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКомплектующихToolStripMenuItem,
            this.toolStripMenuItem1,
            this.категорииToolStripMenuItem,
            this.производителиToolStripMenuItem});
            this.комплектующиеToolStripMenuItem.Name = "комплектующиеToolStripMenuItem";
            this.комплектующиеToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.комплектующиеToolStripMenuItem.Text = "Комплектующие";
            // 
            // списокКомплектующихToolStripMenuItem
            // 
            this.списокКомплектующихToolStripMenuItem.Name = "списокКомплектующихToolStripMenuItem";
            this.списокКомплектующихToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.списокКомплектующихToolStripMenuItem.Text = "Список комплектующих";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 6);
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.категорииToolStripMenuItem.Text = "Категории";
            // 
            // производителиToolStripMenuItem
            // 
            this.производителиToolStripMenuItem.Name = "производителиToolStripMenuItem";
            this.производителиToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.производителиToolStripMenuItem.Text = "Производители";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыПоКатегориямToolStripMenuItem,
            this.заказыПоПроизводителямToolStripMenuItem,
            this.заказыПоМесяцамToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // заказыПоКатегориямToolStripMenuItem
            // 
            this.заказыПоКатегориямToolStripMenuItem.Name = "заказыПоКатегориямToolStripMenuItem";
            this.заказыПоКатегориямToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.заказыПоКатегориямToolStripMenuItem.Text = "Заказы по категориям";
            // 
            // заказыПоПроизводителямToolStripMenuItem
            // 
            this.заказыПоПроизводителямToolStripMenuItem.Name = "заказыПоПроизводителямToolStripMenuItem";
            this.заказыПоПроизводителямToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.заказыПоПроизводителямToolStripMenuItem.Text = "Заказы по производителям";
            // 
            // заказыПоМесяцамToolStripMenuItem
            // 
            this.заказыПоМесяцамToolStripMenuItem.Name = "заказыПоМесяцамToolStripMenuItem";
            this.заказыПоМесяцамToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.заказыПоМесяцамToolStripMenuItem.Text = "Заказы по месяцам";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 1;
            // 
            // gridOrdersList
            // 
            this.gridOrdersList.AllowUserToAddRows = false;
            this.gridOrdersList.AllowUserToDeleteRows = false;
            this.gridOrdersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrdersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrdersList.Location = new System.Drawing.Point(0, 24);
            this.gridOrdersList.Name = "gridOrdersList";
            this.gridOrdersList.ReadOnly = true;
            this.gridOrdersList.Size = new System.Drawing.Size(800, 385);
            this.gridOrdersList.TabIndex = 2;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOrder.Location = new System.Drawing.Point(640, 5);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(154, 32);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Добавить заказ";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridOrdersList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Компьютерный магазин";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrdersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem комплектующиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКомплектующихToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыПоКатегориямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыПоПроизводителямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыПоМесяцамToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView gridOrdersList;
    }
}
