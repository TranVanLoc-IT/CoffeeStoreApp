
namespace CoffeeStoreApp
{
    partial class ManageStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStorage));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtRegis = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txtStoreImp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAcceptImp = new System.Windows.Forms.Button();
            this.cfProvider = new System.Windows.Forms.TextBox();
            this.btnCancelImp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCfCode = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cfQuantityImp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewImp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImp)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtRegis
            // 
            this.txtRegis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRegis.Location = new System.Drawing.Point(87, 194);
            this.txtRegis.Name = "txtRegis";
            this.txtRegis.Size = new System.Drawing.Size(187, 26);
            this.txtRegis.TabIndex = 17;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Teal;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(375, 162);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(106, 43);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "Xem";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(982, 55);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Thông tin nhập hàng";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.txtRegis);
            this.panelInfo.Controls.Add(this.btnView);
            this.panelInfo.Controls.Add(this.txtStoreImp);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.btnAcceptImp);
            this.panelInfo.Controls.Add(this.cfProvider);
            this.panelInfo.Controls.Add(this.btnCancelImp);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.txtCfCode);
            this.panelInfo.Controls.Add(this.dateTimePicker1);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label6);
            this.panelInfo.Controls.Add(this.cfQuantityImp);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Location = new System.Drawing.Point(64, 83);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(877, 223);
            this.panelInfo.TabIndex = 20;
            // 
            // txtStoreImp
            // 
            this.txtStoreImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStoreImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStoreImp.Location = new System.Drawing.Point(213, 17);
            this.txtStoreImp.Name = "txtStoreImp";
            this.txtStoreImp.Size = new System.Drawing.Size(100, 26);
            this.txtStoreImp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(76, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã cửa hàng:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(158, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kí tên";
            // 
            // btnAcceptImp
            // 
            this.btnAcceptImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAcceptImp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAcceptImp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcceptImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptImp.ForeColor = System.Drawing.Color.Green;
            this.btnAcceptImp.Image = ((System.Drawing.Image)(resources.GetObject("btnAcceptImp.Image")));
            this.btnAcceptImp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceptImp.Location = new System.Drawing.Point(673, 162);
            this.btnAcceptImp.Name = "btnAcceptImp";
            this.btnAcceptImp.Size = new System.Drawing.Size(153, 43);
            this.btnAcceptImp.TabIndex = 15;
            this.btnAcceptImp.Text = "Đồng ý";
            this.btnAcceptImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcceptImp.UseVisualStyleBackColor = true;
            this.btnAcceptImp.Click += new System.EventHandler(this.btnAcceptImp_Click);
            // 
            // cfProvider
            // 
            this.cfProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cfProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cfProvider.Location = new System.Drawing.Point(506, 77);
            this.cfProvider.Name = "cfProvider";
            this.cfProvider.Size = new System.Drawing.Size(100, 26);
            this.cfProvider.TabIndex = 5;
            // 
            // btnCancelImp
            // 
            this.btnCancelImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelImp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelImp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCancelImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelImp.ForeColor = System.Drawing.Color.Red;
            this.btnCancelImp.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelImp.Image")));
            this.btnCancelImp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelImp.Location = new System.Drawing.Point(527, 162);
            this.btnCancelImp.Name = "btnCancelImp";
            this.btnCancelImp.Size = new System.Drawing.Size(106, 43);
            this.btnCancelImp.TabIndex = 14;
            this.btnCancelImp.Text = "Hủy";
            this.btnCancelImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelImp.UseVisualStyleBackColor = true;
            this.btnCancelImp.Click += new System.EventHandler(this.btnCancelImp_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(371, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhà cung cấp";
            // 
            // txtCfCode
            // 
            this.txtCfCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCfCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCfCode.Location = new System.Drawing.Point(165, 78);
            this.txtCfCode.Name = "txtCfCode";
            this.txtCfCode.Size = new System.Drawing.Size(100, 26);
            this.txtCfCode.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(526, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(76, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã hàng:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(76, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng nhập:";
            // 
            // cfQuantityImp
            // 
            this.cfQuantityImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cfQuantityImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cfQuantityImp.Location = new System.Drawing.Point(225, 130);
            this.cfQuantityImp.Name = "cfQuantityImp";
            this.cfQuantityImp.Size = new System.Drawing.Size(100, 26);
            this.cfQuantityImp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(371, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày nhập hàng:";
            // 
            // dataGridViewImp
            // 
            this.dataGridViewImp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewImp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewImp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewImp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImp.Location = new System.Drawing.Point(64, 316);
            this.dataGridViewImp.Name = "dataGridViewImp";
            this.dataGridViewImp.RowHeadersWidth = 51;
            this.dataGridViewImp.RowTemplate.Height = 24;
            this.dataGridViewImp.Size = new System.Drawing.Size(877, 212);
            this.dataGridViewImp.TabIndex = 19;
            // 
            // ManageStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.dataGridViewImp);
            this.Name = "ManageStorage";
            this.Text = "ManageStorage";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox txtRegis;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtStoreImp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAcceptImp;
        private System.Windows.Forms.Button btnCancelImp;
        private System.Windows.Forms.TextBox txtCfCode;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cfQuantityImp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewImp;
        private System.Windows.Forms.TextBox cfProvider;
        private System.Windows.Forms.Label label2;
    }
}