
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.success);
            this.panel1.Controls.Add(this.fillBillInfo);
            this.panel1.Controls.Add(this.fillCustomerInfo);
            this.panel1.Controls.Add(this.confirmProduct);
            this.panel1.Location = new System.Drawing.Point(1, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 74);
            this.panel1.TabIndex = 0;
            // 
            // success
            // 
            this.success.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.success.Location = new System.Drawing.Point(758, 0);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(253, 74);
            this.success.TabIndex = 3;
            this.success.Text = "Hoàn tất";
            this.success.UseVisualStyleBackColor = true;
            // 
            // fillBillInfo
            // 
            this.fillBillInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBillInfo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fillBillInfo.Location = new System.Drawing.Point(505, 0);
            this.fillBillInfo.Name = "fillBillInfo";
            this.fillBillInfo.Size = new System.Drawing.Size(253, 74);
            this.fillBillInfo.TabIndex = 2;
            this.fillBillInfo.Text = "Thông tin hóa đơn";
            this.fillBillInfo.UseVisualStyleBackColor = true;
            // 
            // fillCustomerInfo
            // 
            this.fillCustomerInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillCustomerInfo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fillCustomerInfo.Location = new System.Drawing.Point(253, 0);
            this.fillCustomerInfo.Name = "fillCustomerInfo";
            this.fillCustomerInfo.Size = new System.Drawing.Size(253, 74);
            this.fillCustomerInfo.TabIndex = 1;
            this.fillCustomerInfo.Text = "Thông tin khách hàng";
            this.fillCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // confirmProduct
            // 
            this.confirmProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmProduct.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.confirmProduct.Location = new System.Drawing.Point(0, 0);
            this.confirmProduct.Name = "confirmProduct";
            this.confirmProduct.Size = new System.Drawing.Size(253, 74);
            this.confirmProduct.TabIndex = 0;
            this.confirmProduct.Text = "Xác nhận giỏ hàng";
            this.confirmProduct.UseVisualStyleBackColor = true;
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
            this.label1.Padding = new System.Windows.Forms.Padding(340, 20, 300, 20);
            this.label1.Size = new System.Drawing.Size(1014, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thanh toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmProduct_NextStep
            // 
            this.confirmProduct_NextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmProduct_NextStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.confirmProduct_NextStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.confirmProduct_NextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmProduct_NextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmProduct_NextStep.Image = ((System.Drawing.Image)(resources.GetObject("confirmProduct_NextStep.Image")));
            this.confirmProduct_NextStep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmProduct_NextStep.Location = new System.Drawing.Point(848, 454);
            this.confirmProduct_NextStep.Name = "confirmProduct_NextStep";
            this.confirmProduct_NextStep.Size = new System.Drawing.Size(141, 43);
            this.confirmProduct_NextStep.TabIndex = 70;
            this.confirmProduct_NextStep.Text = "Tiếp tục";
            this.confirmProduct_NextStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmProduct_NextStep.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.confirmProduct_NextStep.Visible = false;
=======
            this.confirmProduct_NextStep.Click += new System.EventHandler(this.ChildForm_NextStepHandle);
>>>>>>> a419a1e68aea5648f7664307760934e7a588ec79
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(1, 169);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1013, 279);
            this.mainPanel.TabIndex = 71;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.AutoSize = true;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(679, 457);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(145, 40);
            this.btnReturn.TabIndex = 72;
            this.btnReturn.Text = "Quay về";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.ChildForm_NextStepHandle);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 504);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.confirmProduct_NextStep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Pay";
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load);
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
        private System.Windows.Forms.Button btnReturn;
    }
}