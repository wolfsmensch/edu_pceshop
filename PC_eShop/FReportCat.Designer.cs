namespace PC_eShop
{
    partial class FReportCat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartCat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartCat
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCat.Legends.Add(legend1);
            this.chartCat.Location = new System.Drawing.Point(0, 47);
            this.chartCat.Name = "chartCat";
            this.chartCat.Size = new System.Drawing.Size(800, 405);
            this.chartCat.TabIndex = 0;
            this.chartCat.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 1;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(247, 12);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(138, 20);
            this.dateTo.TabIndex = 4;
            this.dateTo.Value = new System.DateTime(2019, 12, 31, 11, 2, 0, 0);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(78, 12);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(138, 20);
            this.dateFrom.TabIndex = 3;
            this.dateFrom.Value = new System.DateTime(2019, 1, 1, 11, 2, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период с";
            // 
            // FReportCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FReportCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о заказах по категориям";
            ((System.ComponentModel.ISupportInitialize)(this.chartCat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}