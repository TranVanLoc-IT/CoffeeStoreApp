
namespace CoffeeStoreApp
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.success = new System.Windows.Forms.Button();
            this.fillBillInfo = new System.Windows.Forms.Button();
            this.fillCustomerInfo = new System.Windows.Forms.Button();
            this.confirmProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmProduct_NextStep = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.success);
            this.panel1.Controls.Add(this.fillBillInfo);
            this.panel1.Controls.Add(this.fillCustomerInfo);
            this.panel1.Controls.Add(this.confirmProduct);
            this.panel1.Location = new System.Drawing.Point(1, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 92);
            this.panel1.TabIndex = 0;
            // 
            // success
            // 
            this.success.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.success.Location = new System.Drawing.Point(853, 0);
            this.success.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(285, 92);
            this.success.TabIndex = 3;
            this.success.Text = "Hoàn tất";
            this.success.UseVisualStyleBackColor = true;
            // 
            // fillBillInfo
            // 
            this.fillBillInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBillInfo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fillBillInfo.Location = new System.Drawing.Point(568, 0);
            this.fillBillInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fillBillInfo.Name = "fillBillInfo";
            this.fillBillInfo.Size = new System.Drawing.Size(285, 92);
            this.fillBillInfo.TabIndex = 2;
            this.fillBillInfo.Text = "Thông tin hóa đơn";
            this.fillBillInfo.UseVisualStyleBackColor = true;
            // 
            // fillCustomerInfo
            // 
            this.fillCustomerInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillCustomerInfo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fillCustomerInfo.Location = new System.Drawing.Point(285, 0);
            this.fillCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fillCustomerInfo.Name = "fillCustomerInfo";
            this.fillCustomerInfo.Size = new System.Drawing.Size(285, 92);
            this.fillCustomerInfo.TabIndex = 1;
            this.fillCustomerInfo.Text = "Thông tin khách hàng";
            this.fillCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // confirmProduct
            // 
            this.confirmProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmProduct.Image = ((System.Drawing.Image)(resources.GetObject("confirmProduct.Image")));
            this.confirmProduct.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.confirmProduct.Location = new System.Drawing.Point(0, 0);
            this.confirmProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmProduct.Name = "confirmProduct";
            this.confirmProduct.Size = new System.Drawing.Size(285, 92);
            this.confirmProduct.TabIndex = 0;
            this.confirmProduct.Text = "Xác nhận giỏ hàng";
            this.confirmProduct.UseVisualStyleBackColor = true;
            this.confirmProduct.Click += new System.EventHandler(this.btnConfirmProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(382, 25, 338, 25);
            this.label1.Size = new System.Drawing.Size(1158, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thanh toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmProduct_NextStep
            // 
            this.confirmProduct_NextStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.confirmProduct_NextStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.confirmProduct_NextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmProduct_NextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmProduct_NextStep.Image = ((System.Drawing.Image)(resources.GetObject("confirmProduct_NextStep.Image")));
            this.confirmProduct_NextStep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmProduct_NextStep.Location = new System.Drawing.Point(954, 568);
            this.confirmProduct_NextStep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmProduct_NextStep.Name = "confirmProduct_NextStep";
            this.confirmProduct_NextStep.Size = new System.Drawing.Size(159, 54);
            this.confirmProduct_NextStep.TabIndex = 70;
            this.confirmProduct_NextStep.Text = "Tiếp tục";
            this.confirmProduct_NextStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmProduct_NextStep.UseVisualStyleBackColor = true;
            this.confirmProduct_NextStep.Visible = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(1, 211);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1140, 349);
            this.mainPanel.TabIndex = 71;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 630);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.confirmProduct_NextStep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pay";
            this.Text = "Pay";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirmProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmProduct_NextStep;
        private System.Windows.Forms.Button success;
        private System.Windows.Forms.Button fillBillInfo;
        private System.Windows.Forms.Button fillCustomerInfo;
        private System.Windows.Forms.Panel mainPanel;
    }
}