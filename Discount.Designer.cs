namespace ClothShop_Project
{
    partial class Discount
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOfferInformation = new System.Windows.Forms.GroupBox();
            this.lblorderid = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblname1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdatedPrice = new System.Windows.Forms.Button();
            this.btnCalculatedNewPrice = new System.Windows.Forms.Button();
            this.lblP = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpOfferInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\.NET\\ClothShop-Project\\clothing-store-shop-.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(895, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1714, 874);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "OFFER FORM";
            // 
            // grpOfferInformation
            // 
            this.grpOfferInformation.Controls.Add(this.lblorderid);
            this.grpOfferInformation.Controls.Add(this.lblOrder);
            this.grpOfferInformation.Controls.Add(this.label3);
            this.grpOfferInformation.Controls.Add(this.lblProductName);
            this.grpOfferInformation.Controls.Add(this.lblname1);
            this.grpOfferInformation.Controls.Add(this.lblName);
            this.grpOfferInformation.Controls.Add(this.btnUpdatedPrice);
            this.grpOfferInformation.Controls.Add(this.btnCalculatedNewPrice);
            this.grpOfferInformation.Controls.Add(this.lblP);
            this.grpOfferInformation.Controls.Add(this.lblPercent);
            this.grpOfferInformation.Controls.Add(this.txtNewPrice);
            this.grpOfferInformation.Controls.Add(this.txtDiscount);
            this.grpOfferInformation.Controls.Add(this.lblRS);
            this.grpOfferInformation.Controls.Add(this.lblOldPrice);
            this.grpOfferInformation.Controls.Add(this.lbl4);
            this.grpOfferInformation.Controls.Add(this.lbl2);
            this.grpOfferInformation.Controls.Add(this.lbl1);
            this.grpOfferInformation.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOfferInformation.Location = new System.Drawing.Point(37, 81);
            this.grpOfferInformation.Name = "grpOfferInformation";
            this.grpOfferInformation.Size = new System.Drawing.Size(803, 556);
            this.grpOfferInformation.TabIndex = 2;
            this.grpOfferInformation.TabStop = false;
            this.grpOfferInformation.Text = "OfferInformation";
            this.grpOfferInformation.Enter += new System.EventHandler(this.grpOfferInformation_Enter);
            // 
            // lblorderid
            // 
            this.lblorderid.AutoSize = true;
            this.lblorderid.Location = new System.Drawing.Point(543, 48);
            this.lblorderid.Name = "lblorderid";
            this.lblorderid.Size = new System.Drawing.Size(80, 24);
            this.lblorderid.TabIndex = 19;
            this.lblorderid.Text = "OrderID";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(734, 48);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(44, 24);
            this.lblOrder.TabIndex = 18;
            this.lblOrder.Text = "OID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "ProductName";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(384, 87);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(63, 24);
            this.lblProductName.TabIndex = 16;
            this.lblProductName.Text = "label2";
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.Location = new System.Drawing.Point(352, 16);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(63, 24);
            this.lblname1.TabIndex = 15;
            this.lblname1.Text = "label2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(347, 87);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 14;
            // 
            // btnUpdatedPrice
            // 
            this.btnUpdatedPrice.Location = new System.Drawing.Point(98, 422);
            this.btnUpdatedPrice.Name = "btnUpdatedPrice";
            this.btnUpdatedPrice.Size = new System.Drawing.Size(162, 49);
            this.btnUpdatedPrice.TabIndex = 12;
            this.btnUpdatedPrice.Text = "Updated Price";
            this.btnUpdatedPrice.UseVisualStyleBackColor = true;
            this.btnUpdatedPrice.Click += new System.EventHandler(this.btnUpdatedPrice_Click);
            // 
            // btnCalculatedNewPrice
            // 
            this.btnCalculatedNewPrice.Location = new System.Drawing.Point(455, 422);
            this.btnCalculatedNewPrice.Name = "btnCalculatedNewPrice";
            this.btnCalculatedNewPrice.Size = new System.Drawing.Size(233, 49);
            this.btnCalculatedNewPrice.TabIndex = 11;
            this.btnCalculatedNewPrice.Text = "Calculated New Price";
            this.btnCalculatedNewPrice.UseVisualStyleBackColor = true;
            this.btnCalculatedNewPrice.Click += new System.EventHandler(this.btnCalculatedNewPrice_Click);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(537, 307);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(32, 24);
            this.lblP.TabIndex = 10;
            this.lblP.Text = "RS";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(543, 245);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(26, 24);
            this.lblPercent.TabIndex = 9;
            this.lblPercent.Text = "%";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(376, 307);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(129, 31);
            this.txtNewPrice.TabIndex = 8;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(376, 238);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(129, 31);
            this.txtDiscount.TabIndex = 7;
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Location = new System.Drawing.Point(512, 166);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(32, 24);
            this.lblRS.TabIndex = 6;
            this.lblRS.Text = "RS";
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.AutoSize = true;
            this.lblOldPrice.Location = new System.Drawing.Point(372, 165);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(43, 24);
            this.lblOldPrice.TabIndex = 5;
            this.lblOldPrice.Text = "lbl4";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(116, 313);
            this.lbl4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(101, 25);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "New Price";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(41, 238);
            this.lbl2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(219, 25);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Discount in Percentage";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(41, 165);
            this.lbl1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(237, 25);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Original Price Of Product";
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.grpOfferInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Discount";
            this.Text = "Discount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpOfferInformation.ResumeLayout(false);
            this.grpOfferInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOfferInformation;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblOldPrice;
        private System.Windows.Forms.Button btnUpdatedPrice;
        private System.Windows.Forms.Button btnCalculatedNewPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblname1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblorderid;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ErrorProvider errorProvider7;
    }
}