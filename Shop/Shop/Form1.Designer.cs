namespace Shop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.combo_Goods = new System.Windows.Forms.ComboBox();
            this.combo_size = new System.Windows.Forms.ComboBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.button_Cart = new System.Windows.Forms.Button();
            this.button_AddtoCart = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_Goods
            // 
            this.combo_Goods.FormattingEnabled = true;
            this.combo_Goods.Location = new System.Drawing.Point(10, 11);
            this.combo_Goods.Margin = new System.Windows.Forms.Padding(2);
            this.combo_Goods.Name = "combo_Goods";
            this.combo_Goods.Size = new System.Drawing.Size(136, 21);
            this.combo_Goods.TabIndex = 0;
            this.combo_Goods.SelectedIndexChanged += new System.EventHandler(this.combo_Goods_SelectedIndexChanged);
            // 
            // combo_size
            // 
            this.combo_size.FormattingEnabled = true;
            this.combo_size.Location = new System.Drawing.Point(174, 11);
            this.combo_size.Margin = new System.Windows.Forms.Padding(2);
            this.combo_size.Name = "combo_size";
            this.combo_size.Size = new System.Drawing.Size(92, 21);
            this.combo_size.TabIndex = 1;
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(468, 11);
            this.text_price.Margin = new System.Windows.Forms.Padding(2);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(76, 20);
            this.text_price.TabIndex = 2;
            // 
            // button_Cart
            // 
            this.button_Cart.Location = new System.Drawing.Point(469, 74);
            this.button_Cart.Name = "button_Cart";
            this.button_Cart.Size = new System.Drawing.Size(75, 23);
            this.button_Cart.TabIndex = 3;
            this.button_Cart.Text = "Cart";
            this.button_Cart.UseVisualStyleBackColor = true;
            this.button_Cart.Click += new System.EventHandler(this.button_Cart_Click);
            // 
            // button_AddtoCart
            // 
            this.button_AddtoCart.Location = new System.Drawing.Point(10, 74);
            this.button_AddtoCart.Name = "button_AddtoCart";
            this.button_AddtoCart.Size = new System.Drawing.Size(75, 23);
            this.button_AddtoCart.TabIndex = 7;
            this.button_AddtoCart.Text = "Add to Cart";
            this.button_AddtoCart.UseVisualStyleBackColor = true;
            this.button_AddtoCart.Click += new System.EventHandler(this.button_AddtoCart_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(315, 12);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 308);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_AddtoCart);
            this.Controls.Add(this.button_Cart);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.combo_size);
            this.Controls.Add(this.combo_Goods);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox combo_Goods;
        private System.Windows.Forms.ComboBox combo_size;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.Button button_Cart;
        private System.Windows.Forms.Button button_AddtoCart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

