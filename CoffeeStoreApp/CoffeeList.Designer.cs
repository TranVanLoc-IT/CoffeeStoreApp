
namespace CoffeeStoreApp
{
    partial class CoffeeList
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutHot = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.flowLayoutAll = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-25, -126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dòng xe đang bán chạy";
            // 
            // flowLayoutHot
            // 
            this.flowLayoutHot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutHot.AutoScroll = true;
            this.flowLayoutHot.AutoScrollMinSize = new System.Drawing.Size(1279, 100);
            this.flowLayoutHot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutHot.Location = new System.Drawing.Point(12, 59);
            this.flowLayoutHot.Name = "flowLayoutHot";
            this.flowLayoutHot.Size = new System.Drawing.Size(1268, 372);
            this.flowLayoutHot.TabIndex = 11;
            this.flowLayoutHot.WrapContents = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chọn Loại Cà phê";
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Xe tay côn",
            "Xe mô tô",
            "Xe số",
            "Xe tay ga"});
            this.cbFilter.Location = new System.Drawing.Point(232, 437);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(152, 27);
            this.cbFilter.TabIndex = 12;
            // 
            // flowLayoutAll
            // 
            this.flowLayoutAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutAll.AutoScroll = true;
            this.flowLayoutAll.AutoScrollMinSize = new System.Drawing.Size(1279, 100);
            this.flowLayoutAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutAll.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutAll.Location = new System.Drawing.Point(12, 471);
            this.flowLayoutAll.Name = "flowLayoutAll";
            this.flowLayoutAll.Size = new System.Drawing.Size(1268, 379);
            this.flowLayoutAll.TabIndex = 10;
            this.flowLayoutAll.WrapContents = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cà phê nổi bật";
            // 
            // CoffeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1292, 852);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.flowLayoutHot);
            this.Controls.Add(this.flowLayoutAll);
            this.Controls.Add(this.label1);
            this.Name = "CoffeeList";
            this.Text = "CoffeeList";
            this.Load += new System.EventHandler(this.CoffeeList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutHot;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbFilter;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutAll;
        public System.Windows.Forms.Label label3;
    }
}