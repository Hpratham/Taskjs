namespace ClothShop_Project
{
    partial class UCustomer
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
            this.grdUCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdUCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUCustomer
            // 
            this.grdUCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUCustomer.Location = new System.Drawing.Point(12, 32);
            this.grdUCustomer.Name = "grdUCustomer";
            this.grdUCustomer.RowHeadersWidth = 51;
            this.grdUCustomer.RowTemplate.Height = 24;
            this.grdUCustomer.Size = new System.Drawing.Size(1120, 660);
            this.grdUCustomer.TabIndex = 1;
            this.grdUCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUCustomer_CellContentClick);
            // 
            // UCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1166, 714);
            this.Controls.Add(this.grdUCustomer);
            this.Name = "UCustomer";
            this.Text = "UCustomer";
            this.Load += new System.EventHandler(this.UCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUCustomer;
    }
}