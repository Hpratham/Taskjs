namespace ClothShop_Project
{
    partial class Size
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblRealPrice = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.cmbbxProduct = new System.Windows.Forms.ComboBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.txtRealPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(12, 70);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 27);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(12, 168);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(75, 27);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(12, 245);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 27);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // lblRealPrice
            // 
            this.lblRealPrice.AutoSize = true;
            this.lblRealPrice.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealPrice.Location = new System.Drawing.Point(12, 336);
            this.lblRealPrice.Name = "lblRealPrice";
            this.lblRealPrice.Size = new System.Drawing.Size(89, 27);
            this.lblRealPrice.TabIndex = 3;
            this.lblRealPrice.Text = "RealPrice";
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.Location = new System.Drawing.Point(12, 434);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(50, 27);
            this.lblMRP.TabIndex = 4;
            this.lblMRP.Text = "MRP";
            // 
            // cmbbxType
            // 
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(230, 67);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(121, 24);
            this.cmbbxType.TabIndex = 5;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // cmbbxProduct
            // 
            this.cmbbxProduct.FormattingEnabled = true;
            this.cmbbxProduct.Location = new System.Drawing.Point(230, 165);
            this.cmbbxProduct.Name = "cmbbxProduct";
            this.cmbbxProduct.Size = new System.Drawing.Size(121, 24);
            this.cmbbxProduct.TabIndex = 6;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(230, 239);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(121, 22);
            this.txtsize.TabIndex = 7;
            // 
            // txtMRP
            // 
            this.txtMRP.Location = new System.Drawing.Point(230, 412);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(121, 22);
            this.txtMRP.TabIndex = 8;
            // 
            // txtRealPrice
            // 
            this.txtRealPrice.Location = new System.Drawing.Point(230, 321);
            this.txtRealPrice.Name = "txtRealPrice";
            this.txtRealPrice.Size = new System.Drawing.Size(121, 22);
            this.txtRealPrice.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(526, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1018, 507);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRealPrice);
            this.Controls.Add(this.txtMRP);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.cmbbxProduct);
            this.Controls.Add(this.cmbbxType);
            this.Controls.Add(this.lblMRP);
            this.Controls.Add(this.lblRealPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblType);
            this.Name = "Size";
            this.Text = "Size";
            this.Load += new System.EventHandler(this.Size_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblRealPrice;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.ComboBox cmbbxProduct;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.TextBox txtRealPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}