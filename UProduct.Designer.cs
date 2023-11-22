namespace ClothShop_Project
{
    partial class UProduct
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
            this.datagrdProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrdProduct
            // 
            this.datagrdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdProduct.Location = new System.Drawing.Point(83, 83);
            this.datagrdProduct.Name = "datagrdProduct";
            this.datagrdProduct.RowHeadersWidth = 51;
            this.datagrdProduct.RowTemplate.Height = 24;
            this.datagrdProduct.Size = new System.Drawing.Size(1170, 594);
            this.datagrdProduct.TabIndex = 0;
            this.datagrdProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1265, 701);
            this.Controls.Add(this.datagrdProduct);
            this.Name = "UProduct";
            this.Text = "UProduct";
            this.Load += new System.EventHandler(this.UProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrdProduct;
    }
}