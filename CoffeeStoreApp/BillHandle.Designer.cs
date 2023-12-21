
namespace CoffeeStoreApp
{
    partial class BillHandle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillHandle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.btnTable = new System.Windows.Forms.Button();
            this.txtTableCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtBillCode
            // 
            this.txtBillCode.Location = new System.Drawing.Point(123, 18);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(100, 22);
            this.txtBillCode.TabIndex = 1;
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.Teal;
            this.btnTable.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Location = new System.Drawing.Point(147, 245);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(90, 40);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "Xong";
            this.btnTable.UseVisualStyleBackColor = false;
            // 
            // txtTableCode
            // 
            this.txtTableCode.Location = new System.Drawing.Point(113, 55);
            this.txtTableCode.Name = "txtTableCode";
            this.txtTableCode.Size = new System.Drawing.Size(100, 22);
            this.txtTableCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã bàn";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(33, 110);
            this.txtSP.Multiline = true;
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(198, 129);
            this.txtSP.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sản phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BillHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.txtBillCode);
            this.Controls.Add(this.label1);
            this.Name = "BillHandle";
            this.Size = new System.Drawing.Size(254, 288);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBillCode;
        public System.Windows.Forms.Button btnTable;
        public System.Windows.Forms.TextBox txtTableCode;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSP;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
