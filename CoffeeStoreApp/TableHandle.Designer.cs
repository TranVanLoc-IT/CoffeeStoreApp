
namespace CoffeeStoreApp
{
    partial class TableHandle
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.txtTableUsing = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEmptyTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(7, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số bàn ăn đang dùng:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1016, 291);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnClearTable
            // 
            this.btnClearTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTable.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClearTable.Location = new System.Drawing.Point(889, 159);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(115, 38);
            this.btnClearTable.TabIndex = 0;
            this.btnClearTable.Text = "Dọn bàn";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // txtTableUsing
            // 
            this.txtTableUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtTableUsing.Location = new System.Drawing.Point(256, 140);
            this.txtTableUsing.Name = "txtTableUsing";
            this.txtTableUsing.Size = new System.Drawing.Size(100, 32);
            this.txtTableUsing.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1016, 55);
            this.textBox2.TabIndex = 97;
            this.textBox2.Text = "Xử lý dịch vụ bàn ăn";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmptyTable
            // 
            this.txtEmptyTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtEmptyTable.Location = new System.Drawing.Point(622, 139);
            this.txtEmptyTable.Name = "txtEmptyTable";
            this.txtEmptyTable.Size = new System.Drawing.Size(100, 32);
            this.txtEmptyTable.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(369, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 26);
            this.label2.TabIndex = 98;
            this.label2.Text = "Số bàn ăn còn trống:";
            // 
            // TableHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 504);
            this.Controls.Add(this.txtEmptyTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.txtTableUsing);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "TableHandle";
            this.Text = "TableHandle";
            this.Load += new System.EventHandler(this.TableHandle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.TextBox txtTableUsing;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtEmptyTable;
        private System.Windows.Forms.Label label2;
    }
}