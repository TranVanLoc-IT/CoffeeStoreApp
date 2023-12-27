
namespace CoffeeStoreApp
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.workTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnTableHandle = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.btnTableHandle);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 664);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.workTime);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lbId);
            this.panel4.Location = new System.Drawing.Point(3, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 100);
            this.panel4.TabIndex = 10;
            // 
            // workTime
            // 
            this.workTime.AutoSize = true;
            this.workTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workTime.Location = new System.Drawing.Point(93, 58);
            this.workTime.Name = "workTime";
            this.workTime.Size = new System.Drawing.Size(91, 17);
            this.workTime.TabIndex = 12;
            this.workTime.Text = "18G30 - 20G";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(93, 19);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(82, 26);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "NV002";
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStatistic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.SeaShell;
            this.btnStatistic.Location = new System.Drawing.Point(1, 431);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(197, 85);
            this.btnStatistic.TabIndex = 9;
            this.btnStatistic.Text = "Thống kê doanh thu";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.SeaShell;
            this.btnPay.Location = new System.Drawing.Point(1, 305);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(197, 63);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnTableHandle
            // 
            this.btnTableHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTableHandle.FlatAppearance.BorderSize = 0;
            this.btnTableHandle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTableHandle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnTableHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableHandle.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableHandle.ForeColor = System.Drawing.Color.SeaShell;
            this.btnTableHandle.Location = new System.Drawing.Point(1, 368);
            this.btnTableHandle.Name = "btnTableHandle";
            this.btnTableHandle.Size = new System.Drawing.Size(197, 63);
            this.btnTableHandle.TabIndex = 7;
            this.btnTableHandle.Text = "Bàn ăn";
            this.btnTableHandle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableHandle.UseVisualStyleBackColor = false;
            this.btnTableHandle.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.SeaShell;
            this.btnCustomer.Location = new System.Drawing.Point(1, 242);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(197, 63);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.SeaShell;
            this.btnCart.Location = new System.Drawing.Point(1, 179);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(197, 63);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "Giỏ hàng";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.SeaShell;
            this.btnView.Location = new System.Drawing.Point(1, 116);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(197, 63);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Xem sản phẩm";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 113);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(900, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 31);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(907, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.SeaShell;
            this.linkLabel1.Location = new System.Drawing.Point(520, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(351, 35);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trung Nguyen Coffee";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 113);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(1034, 551);
            this.mainPanel.TabIndex = 2;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 664);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnTableHandle;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label workTime;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}