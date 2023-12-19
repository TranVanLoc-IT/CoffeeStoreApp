
namespace CoffeeStoreApp
{
    partial class TableCard
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
            this.btnTable = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(3, 2);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(110, 74);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "Table 1";
            this.btnTable.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TableCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTable);
            this.Name = "TableCard";
            this.Size = new System.Drawing.Size(116, 77);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button button2;
    }
}
