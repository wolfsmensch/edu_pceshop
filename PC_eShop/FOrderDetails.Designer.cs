namespace PC_eShop
{
    partial class FOrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridDevice = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textN = new System.Windows.Forms.TextBox();
            this.textFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDevice
            // 
            this.gridDevice.AllowUserToAddRows = false;
            this.gridDevice.AllowUserToDeleteRows = false;
            this.gridDevice.BackgroundColor = System.Drawing.Color.White;
            this.gridDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDevice.Location = new System.Drawing.Point(0, 0);
            this.gridDevice.Name = "gridDevice";
            this.gridDevice.ReadOnly = true;
            this.gridDevice.Size = new System.Drawing.Size(800, 450);
            this.gridDevice.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textFIO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заказа";
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(104, 12);
            this.textN.Name = "textN";
            this.textN.ReadOnly = true;
            this.textN.Size = new System.Drawing.Size(77, 20);
            this.textN.TabIndex = 1;
            // 
            // textFIO
            // 
            this.textFIO.Location = new System.Drawing.Point(283, 12);
            this.textFIO.Name = "textFIO";
            this.textFIO.ReadOnly = true;
            this.textFIO.Size = new System.Drawing.Size(239, 20);
            this.textFIO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО заказчика";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(642, 12);
            this.textPhone.Name = "textPhone";
            this.textPhone.ReadOnly = true;
            this.textPhone.Size = new System.Drawing.Size(140, 20);
            this.textPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон заказчика";
            // 
            // FOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Детальный просмотр заказа";
            ((System.ComponentModel.ISupportInitialize)(this.gridDevice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDevice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label label1;
    }
}