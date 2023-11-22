namespace ClothShop_Project
{
    partial class Order
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
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.cmbbxProduct = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grdOrderData = new System.Windows.Forms.DataGridView();
            this.btnAddtocart = new System.Windows.Forms.Button();
            this.btnremovefromcart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnorderConfirm = new System.Windows.Forms.Button();
            this.OrderListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(27, 87);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // cmbbxType
            // 
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(294, 87);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(121, 24);
            this.cmbbxType.TabIndex = 2;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // cmbbxProduct
            // 
            this.cmbbxProduct.FormattingEnabled = true;
            this.cmbbxProduct.Location = new System.Drawing.Point(294, 208);
            this.cmbbxProduct.Name = "cmbbxProduct";
            this.cmbbxProduct.Size = new System.Drawing.Size(121, 24);
            this.cmbbxProduct.TabIndex = 3;
            this.cmbbxProduct.SelectedIndexChanged += new System.EventHandler(this.cmbbxProduct_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(27, 308);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(294, 308);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(107, 415);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(323, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grdOrderData
            // 
            this.grdOrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderData.Location = new System.Drawing.Point(580, 43);
            this.grdOrderData.Name = "grdOrderData";
            this.grdOrderData.RowHeadersWidth = 51;
            this.grdOrderData.RowTemplate.Height = 24;
            this.grdOrderData.Size = new System.Drawing.Size(372, 409);
            this.grdOrderData.TabIndex = 8;
            this.grdOrderData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderData_CellClick);
            this.grdOrderData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderData_CellContentClick);
            this.grdOrderData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdOrderData_CellMouseClick);
            // 
            // btnAddtocart
            // 
            this.btnAddtocart.Location = new System.Drawing.Point(1030, 93);
            this.btnAddtocart.Name = "btnAddtocart";
            this.btnAddtocart.Size = new System.Drawing.Size(75, 53);
            this.btnAddtocart.TabIndex = 9;
            this.btnAddtocart.Text = "Add toCart";
            this.btnAddtocart.UseVisualStyleBackColor = true;
            this.btnAddtocart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnremovefromcart
            // 
            this.btnremovefromcart.Location = new System.Drawing.Point(1015, 209);
            this.btnremovefromcart.Name = "btnremovefromcart";
            this.btnremovefromcart.Size = new System.Drawing.Size(129, 40);
            this.btnremovefromcart.TabIndex = 10;
            this.btnremovefromcart.Text = "RemoveFromCart";
            this.btnremovefromcart.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1350, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(1350, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(1350, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(1505, 60);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(135, 22);
            this.txtName1.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1505, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 22);
            this.txtPassword.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1505, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1086, 638);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1288, 632);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 22);
            this.textBox4.TabIndex = 18;
            // 
            // btnorderConfirm
            // 
            this.btnorderConfirm.Location = new System.Drawing.Point(1162, 716);
            this.btnorderConfirm.Name = "btnorderConfirm";
            this.btnorderConfirm.Size = new System.Drawing.Size(137, 23);
            this.btnorderConfirm.TabIndex = 19;
            this.btnorderConfirm.Text = "OrderConfirm";
            this.btnorderConfirm.UseVisualStyleBackColor = true;
            // 
            // OrderListView
            // 
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(1015, 293);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(679, 295);
            this.OrderListView.TabIndex = 20;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1746, 742);
            this.Controls.Add(this.OrderListView);
            this.Controls.Add(this.btnorderConfirm);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnremovefromcart);
            this.Controls.Add(this.btnAddtocart);
            this.Controls.Add(this.grdOrderData);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cmbbxProduct);
            this.Controls.Add(this.cmbbxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblType);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.ComboBox cmbbxProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView grdOrderData;
        private System.Windows.Forms.Button btnAddtocart;
        private System.Windows.Forms.Button btnremovefromcart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnorderConfirm;
        private System.Windows.Forms.ListView OrderListView;
    }
}