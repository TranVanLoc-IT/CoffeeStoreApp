
namespace CoffeeStoreApp
{
    partial class StatisticIncome
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbStatisticIncome = new System.Windows.Forms.GroupBox();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCfIdOrTypeStatistic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.lbTotalIncome = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbSumOfCfSold = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbStatisticTimeOptions = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbStatisticIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStatisticIncome
            // 
            this.gbStatisticIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatisticIncome.AutoSize = true;
            this.gbStatisticIncome.Controls.Add(this.chartIncome);
            this.gbStatisticIncome.Controls.Add(this.button1);
            this.gbStatisticIncome.Controls.Add(this.txtCfIdOrTypeStatistic);
            this.gbStatisticIncome.Controls.Add(this.label11);
            this.gbStatisticIncome.Controls.Add(this.textBox2);
            this.gbStatisticIncome.Controls.Add(this.label25);
            this.gbStatisticIncome.Controls.Add(this.lbTotalIncome);
            this.gbStatisticIncome.Controls.Add(this.lb);
            this.gbStatisticIncome.Controls.Add(this.lbSumOfCfSold);
            this.gbStatisticIncome.Controls.Add(this.label26);
            this.gbStatisticIncome.Controls.Add(this.cbStatisticTimeOptions);
            this.gbStatisticIncome.Controls.Add(this.label27);
            this.gbStatisticIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatisticIncome.Location = new System.Drawing.Point(50, 98);
            this.gbStatisticIncome.Name = "gbStatisticIncome";
            this.gbStatisticIncome.Size = new System.Drawing.Size(953, 435);
            this.gbStatisticIncome.TabIndex = 95;
            this.gbStatisticIncome.TabStop = false;
            this.gbStatisticIncome.Text = "Thống kê doanh thu";
            // 
            // chartIncome
            // 
            this.chartIncome.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea1.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIncome.Legends.Add(legend1);
            this.chartIncome.Location = new System.Drawing.Point(23, 37);
            this.chartIncome.Name = "chartIncome";
            this.chartIncome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartIncome.Series.Add(series1);
            this.chartIncome.Size = new System.Drawing.Size(474, 372);
            this.chartIncome.TabIndex = 56;
            this.chartIncome.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Peru;
            this.button1.Location = new System.Drawing.Point(553, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 55;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCfIdOrTypeStatistic
            // 
            this.txtCfIdOrTypeStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCfIdOrTypeStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCfIdOrTypeStatistic.Location = new System.Drawing.Point(695, 88);
            this.txtCfIdOrTypeStatistic.Multiline = true;
            this.txtCfIdOrTypeStatistic.Name = "txtCfIdOrTypeStatistic";
            this.txtCfIdOrTypeStatistic.Size = new System.Drawing.Size(108, 26);
            this.txtCfIdOrTypeStatistic.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(565, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Mã/loại cà phê";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(679, 235);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 98);
            this.textBox2.TabIndex = 52;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(567, 238);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 20);
            this.label25.TabIndex = 51;
            this.label25.Text = "Đánh giá:";
            // 
            // lbTotalIncome
            // 
            this.lbTotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalIncome.AutoSize = true;
            this.lbTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalIncome.Location = new System.Drawing.Point(718, 182);
            this.lbTotalIncome.Name = "lbTotalIncome";
            this.lbTotalIncome.Size = new System.Drawing.Size(14, 20);
            this.lbTotalIncome.TabIndex = 50;
            this.lbTotalIncome.Text = " ";
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(564, 184);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(134, 20);
            this.lb.TabIndex = 49;
            this.lb.Text = "Tổng doanh thu: ";
            // 
            // lbSumOfCfSold
            // 
            this.lbSumOfCfSold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSumOfCfSold.AutoSize = true;
            this.lbSumOfCfSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumOfCfSold.Location = new System.Drawing.Point(683, 135);
            this.lbSumOfCfSold.Name = "lbSumOfCfSold";
            this.lbSumOfCfSold.Size = new System.Drawing.Size(14, 20);
            this.lbSumOfCfSold.TabIndex = 48;
            this.lbSumOfCfSold.Text = " ";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(565, 140);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 20);
            this.label26.TabIndex = 47;
            this.label26.Text = "Số lượng bán";
            // 
            // cbStatisticTimeOptions
            // 
            this.cbStatisticTimeOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatisticTimeOptions.FormattingEnabled = true;
            this.cbStatisticTimeOptions.Items.AddRange(new object[] {
            "Hôm nay"});
            this.cbStatisticTimeOptions.Location = new System.Drawing.Point(705, 37);
            this.cbStatisticTimeOptions.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatisticTimeOptions.Name = "cbStatisticTimeOptions";
            this.cbStatisticTimeOptions.Size = new System.Drawing.Size(187, 28);
            this.cbStatisticTimeOptions.TabIndex = 45;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(564, 45);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(133, 20);
            this.label27.TabIndex = 44;
            this.label27.Text = "Doanh thu theo: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1033, 55);
            this.textBox1.TabIndex = 96;
            this.textBox1.Text = "Thống kê doanh thu";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatisticIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 553);
            this.Controls.Add(this.gbStatisticIncome);
            this.Controls.Add(this.textBox1);
            this.Name = "StatisticIncome";
            this.Text = "StatisticIncome";
            this.Load += new System.EventHandler(this.StatisticIncome_Load);
            this.gbStatisticIncome.ResumeLayout(false);
            this.gbStatisticIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStatisticIncome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCfIdOrTypeStatistic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbTotalIncome;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbSumOfCfSold;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbStatisticTimeOptions;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
    }
}