namespace LibraryWinForm
{
    partial class FormValidePurchase
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
            txtProductName = new TextBox();
            txtProductPrice = new TextBox();
            btnAddToCart = new Button();
            numericUpDownQuantity = new NumericUpDown();
            DisplayCartProducts = new DataGridView();
            btnConfirmOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DisplayCartProducts).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(81, 69);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(168, 27);
            txtProductName.TabIndex = 0;
            txtProductName.TextChanged += textBox1_TextChanged;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(81, 157);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(168, 27);
            txtProductPrice.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = SystemColors.ActiveCaption;
            btnAddToCart.ForeColor = SystemColors.ControlText;
            btnAddToCart.Location = new Point(550, 100);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(166, 58);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Додати товар";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += button1_Click;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(290, 117);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(150, 27);
            numericUpDownQuantity.TabIndex = 3;
            numericUpDownQuantity.ValueChanged += numericUpDownQuantity_ValueChanged;
            // 
            // DisplayCartProducts
            // 
            DisplayCartProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisplayCartProducts.Location = new Point(41, 261);
            DisplayCartProducts.Name = "DisplayCartProducts";
            DisplayCartProducts.RowHeadersWidth = 51;
            DisplayCartProducts.Size = new Size(327, 148);
            DisplayCartProducts.TabIndex = 4;
            DisplayCartProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = SystemColors.ActiveCaption;
            btnConfirmOrder.Location = new Point(548, 290);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(168, 50);
            btnConfirmOrder.TabIndex = 5;
            btnConfirmOrder.Text = "Підтвердити замовлення";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += button1_Click_1;
            // 
            // FormValidePurchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmOrder);
            Controls.Add(DisplayCartProducts);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(btnAddToCart);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductName);
            Name = "FormValidePurchase";
            Text = "FormValidePurchase";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)DisplayCartProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private TextBox txtProductPrice;
        private Button btnAddToCart;
        private NumericUpDown numericUpDownQuantity;
        private DataGridView DisplayCartProducts;
        private Button btnConfirmOrder;
    }
}