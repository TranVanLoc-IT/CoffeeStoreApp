
namespace CoffeeStoreApp
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.insert = new System.Windows.Forms.Button();
            this.panelCusinfo = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.txtCusSDT = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelCusinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // insert
            // 
            this.insert.AutoSize = true;
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.insert.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.SaddleBrown;
            this.insert.Image = ((System.Drawing.Image)(resources.GetObject("insert.Image")));
            this.insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insert.Location = new System.Drawing.Point(642, 362);
            this.insert.Margin = new System.Windows.Forms.Padding(4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(135, 53);
            this.insert.TabIndex = 68;
            this.insert.Text = "Thêm";
            this.insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.btnEditCus_Click);
            // 
            // panelCusinfo
            // 
            this.panelCusinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCusinfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCusinfo.Controls.Add(this.txtEmail);
            this.panelCusinfo.Controls.Add(this.label2);
            this.panelCusinfo.Controls.Add(this.label13);
            this.panelCusinfo.Controls.Add(this.txtCusAddress);
            this.panelCusinfo.Controls.Add(this.label12);
            this.panelCusinfo.Controls.Add(this.txtCusName);
            this.panelCusinfo.Controls.Add(this.label15);
            this.panelCusinfo.Controls.Add(this.txtCustomerType);
            this.panelCusinfo.Controls.Add(this.txtCusSDT);
            this.panelCusinfo.Controls.Add(this.label20);
            this.panelCusinfo.Location = new System.Drawing.Point(44, 135);
            this.panelCusinfo.Name = "panelCusinfo";
            this.panelCusinfo.Size = new System.Drawing.Size(933, 177);
            this.panelCusinfo.TabIndex = 65;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(643, 75);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 22);
            this.txtEmail.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(483, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Email:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label13.Location = new System.Drawing.Point(77, 117);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Địa chỉ:";
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCusAddress.Location = new System.Drawing.Point(194, 97);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusAddress.Multiline = true;
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(232, 49);
            this.txtCusAddress.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label12.Location = new System.Drawing.Point(473, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Tên khách hàng:";
            // 
            // txtCusName
            // 
            this.txtCusName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCusName.Location = new System.Drawing.Point(649, 27);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(233, 22);
            this.txtCusName.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label15.Location = new System.Drawing.Point(77, 41);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Số điện thoại:";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerType.Location = new System.Drawing.Point(643, 119);
            this.txtCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(243, 22);
            this.txtCustomerType.TabIndex = 34;
            // 
            // txtCusSDT
            // 
            this.txtCusSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCusSDT.Location = new System.Drawing.Point(232, 34);
            this.txtCusSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusSDT.Name = "txtCusSDT";
            this.txtCusSDT.Size = new System.Drawing.Size(166, 22);
            this.txtCusSDT.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label20.Location = new System.Drawing.Point(483, 122);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 20);
            this.label20.TabIndex = 33;
            this.label20.Text = "Loại khách:";
            // 
            // txtCusId
            // 
            this.txtCusId.Location = new System.Drawing.Point(176, 89);
            this.txtCusId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(184, 22);
            this.txtCusId.TabIndex = 64;
            this.txtCusId.TextChanged += new System.EventHandler(this.txtCusId_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label27.Location = new System.Drawing.Point(40, 96);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(123, 20);
            this.label27.TabIndex = 63;
            this.label27.Text = "CCCD khách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 27);
            this.label1.TabIndex = 69;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1016, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.panelCusinfo);
            this.Controls.Add(this.txtCusId);
            this.Controls.Add(this.label27);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelCusinfo.ResumeLayout(false);
            this.panelCusinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Panel panelCusinfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.TextBox txtCusSDT;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
    }
}