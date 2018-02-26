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
            this.SuspendLayout();
            // 
            // combo_Goods
            // 
            this.combo_Goods.FormattingEnabled = true;
            this.combo_Goods.Location = new System.Drawing.Point(13, 13);
            this.combo_Goods.Name = "combo_Goods";
            this.combo_Goods.Size = new System.Drawing.Size(180, 24);
            this.combo_Goods.TabIndex = 0;
            this.combo_Goods.SelectedIndexChanged += new System.EventHandler(this.combo_Goods_SelectedIndexChanged);
            // 
            // combo_size
            // 
            this.combo_size.FormattingEnabled = true;
            this.combo_size.Location = new System.Drawing.Point(232, 11);
            this.combo_size.Name = "combo_size";
            this.combo_size.Size = new System.Drawing.Size(121, 24);
            this.combo_size.TabIndex = 1;
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(377, 11);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(100, 22);
            this.text_price.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 379);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.combo_size);
            this.Controls.Add(this.combo_Goods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox combo_Goods;
        private System.Windows.Forms.ComboBox combo_size;
        private System.Windows.Forms.TextBox text_price;
    }
}

