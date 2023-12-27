
namespace CoffeeStoreApp
{
    partial class BillInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTableCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelTable = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.flowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTake = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTake);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTableCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotalMoney);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVAT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBillCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtTableCode
            // 
            this.txtTableCode.Enabled = false;
            this.txtTableCode.Location = new System.Drawing.Point(312, 23);
            this.txtTableCode.Name = "txtTableCode";
            this.txtTableCode.Size = new System.Drawing.Size(86, 30);
            this.txtTableCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã bàn";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Enabled = false;
            this.txtTotalMoney.Location = new System.Drawing.Point(130, 185);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(163, 30);
            this.txtTotalMoney.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền";
            // 
            // txtVAT
            // 
            this.txtVAT.Enabled = false;
            this.txtVAT.Location = new System.Drawing.Point(79, 131);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(136, 30);
            this.txtVAT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "VAT";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(146, 80);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(258, 30);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtBillCode
            // 
            this.txtBillCode.Enabled = false;
            this.txtBillCode.Location = new System.Drawing.Point(130, 27);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(100, 30);
            this.txtBillCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnCancelTable
            // 
            this.btnCancelTable.BackColor = System.Drawing.Color.Red;
            this.btnCancelTable.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCancelTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTable.ForeColor = System.Drawing.Color.White;
            this.btnCancelTable.Location = new System.Drawing.Point(533, 2);
            this.btnCancelTable.Name = "btnCancelTable";
            this.btnCancelTable.Size = new System.Drawing.Size(108, 40);
            this.btnCancelTable.TabIndex = 3;
            this.btnCancelTable.Text = "Hủy bàn";
            this.btnCancelTable.UseVisualStyleBackColor = false;
            this.btnCancelTable.Click += new System.EventHandler(this.btnCancelTable_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.Green;
            this.btnCreateBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.btnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBill.ForeColor = System.Drawing.Color.White;
            this.btnCreateBill.Location = new System.Drawing.Point(482, 186);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(165, 40);
            this.btnCreateBill.TabIndex = 4;
            this.btnCreateBill.Text = "Tạo hóa đơn";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // flowTable
            // 
            this.flowTable.AutoScroll = true;
            this.flowTable.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTable.Location = new System.Drawing.Point(647, 1);
            this.flowTable.Name = "flowTable";
            this.flowTable.Size = new System.Drawing.Size(347, 232);
            this.flowTable.TabIndex = 5;
            // 
            // txtTake
            // 
            this.txtTake.Location = new System.Drawing.Point(316, 129);
            this.txtTake.Name = "txtTake";
            this.txtTake.Size = new System.Drawing.Size(159, 30);
            this.txtTake.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tiền nhận";
            // 
            // BillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 232);
            this.Controls.Add(this.flowTable);
            this.Controls.Add(this.btnCreateBill);
            this.Controls.Add(this.btnCancelTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "BillInfo";
            this.Text = "BillInfo";
            this.Load += new System.EventHandler(this.BillInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTableCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelTable;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.FlowLayoutPanel flowTable;
        private System.Windows.Forms.TextBox txtTake;
        private System.Windows.Forms.Label label6;
    }
}