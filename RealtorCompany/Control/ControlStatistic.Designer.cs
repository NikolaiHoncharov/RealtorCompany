namespace RealtorCompany.Control
{
    partial class ControlStatistic
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.pnlHeader2 = new System.Windows.Forms.Panel();
            this.charStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.White;
            this.PnlHeader.Controls.Add(this.lblStatistic);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Margin = new System.Windows.Forms.Padding(6);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1006, 46);
            this.PnlHeader.TabIndex = 82;
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Font = new System.Drawing.Font("Segoe Script", 17F, System.Drawing.FontStyle.Bold);
            this.lblStatistic.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblStatistic.Location = new System.Drawing.Point(357, 5);
            this.lblStatistic.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(381, 48);
            this.lblStatistic.TabIndex = 1;
            this.lblStatistic.Text = "Статистика продаж";
            // 
            // pnlHeader2
            // 
            this.pnlHeader2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader2.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.pnlHeader2.Location = new System.Drawing.Point(0, 46);
            this.pnlHeader2.Margin = new System.Windows.Forms.Padding(6);
            this.pnlHeader2.Name = "pnlHeader2";
            this.pnlHeader2.Size = new System.Drawing.Size(1006, 10);
            this.pnlHeader2.TabIndex = 84;
            // 
            // charStatistic
            // 
            chartArea1.Name = "ChartArea1";
            this.charStatistic.ChartAreas.Add(chartArea1);
            this.charStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.charStatistic.Legends.Add(legend1);
            this.charStatistic.Location = new System.Drawing.Point(0, 56);
            this.charStatistic.Name = "charStatistic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.charStatistic.Series.Add(series1);
            this.charStatistic.Size = new System.Drawing.Size(1006, 504);
            this.charStatistic.TabIndex = 85;
            // 
            // ControlStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.charStatistic);
            this.Controls.Add(this.pnlHeader2);
            this.Controls.Add(this.PnlHeader);
            this.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ControlStatistic";
            this.Size = new System.Drawing.Size(1006, 560);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Panel pnlHeader2;
        private System.Windows.Forms.DataVisualization.Charting.Chart charStatistic;
    }
}
