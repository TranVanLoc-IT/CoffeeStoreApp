
namespace CoffeeStoreApp
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.labelCart = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCart.Location = new System.Drawing.Point(27, 15);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(126, 32);
            this.labelCart.TabIndex = 10;
            this.labelCart.Text = "Giỏ hàng";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(756, 373);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(177, 43);
            this.btnPay.TabIndex = 79;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(64, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Số lượng:";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Enabled = false;
            this.txtTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtTotalQuantity.Location = new System.Drawing.Point(175, 388);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.Size = new System.Drawing.Size(47, 28);
            this.txtTotalQuantity.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(236, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Tổng thanh toán:";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Enabled = false;
            this.txtTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtTotalMoney.Location = new System.Drawing.Point(395, 388);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(203, 28);
            this.txtTotalMoney.TabIndex = 75;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCart.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.GridColor = System.Drawing.Color.SandyBrown;
            this.dataGridViewCart.Location = new System.Drawing.Point(65, 85);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 24;
            this.dataGridViewCart.Size = new System.Drawing.Size(676, 283);
            this.dataGridViewCart.TabIndex = 74;
            this.dataGridViewCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_Cart_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(756, 109);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 43);
            this.btnRemove.TabIndex = 73;
            this.btnRemove.Text = "Xóa ";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 504);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalMoney);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.labelCart);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button btnRemove;
    }
}