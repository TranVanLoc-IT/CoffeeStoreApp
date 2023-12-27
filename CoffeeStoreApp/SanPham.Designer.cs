
namespace CoffeeStoreApp
{
    partial class SanPham
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
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.txt_TenSp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSP
            // 
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(74, 145);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(976, 407);
            this.dgvSP.TabIndex = 11;
            this.dgvSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellContentClick);
            // 
            // txt_Gia
            // 
            this.txt_Gia.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gia.Location = new System.Drawing.Point(221, 111);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(253, 28);
            this.txt_Gia.TabIndex = 9;
            // 
            // txt_TenSp
            // 
            this.txt_TenSp.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSp.Location = new System.Drawing.Point(221, 41);
            this.txt_TenSp.Name = "txt_TenSp";
            this.txt_TenSp.Size = new System.Drawing.Size(253, 28);
            this.txt_TenSp.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Chocolate;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Sua.Location = new System.Drawing.Point(893, 87);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(105, 48);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Chocolate;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa.Location = new System.Drawing.Point(761, 88);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(99, 51);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Chocolate;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Them.Location = new System.Drawing.Point(624, 90);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 48);
            this.btn_Them.TabIndex = 15;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1072, 570);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.txt_TenSp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txt_TenSp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
    }
}