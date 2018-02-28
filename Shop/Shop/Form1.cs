using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        GoodsManager manager;
        List<GoodsModel> items;
        List<GoodsModel> size;
        public List<GoodsModel> cart;
        public int rownumbers = 0;

        public Form1()
        {
            InitializeComponent();

            manager = new GoodsManager();
            items = manager.GetItems();
            size = manager.GetSize();
            cart = manager.Get();

            for (int i = 0; i < items.Count; i++)
            {
                combo_Goods.Items.Add(items[i].name);
                combo_size.Items.Add(size[i].size);
                
            }
            
            
        }

        private void combo_Goods_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_price.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Value) * (items[combo_Goods.SelectedIndex].price));
        }

        private void button_Cart_Click(object sender, EventArgs e)
        {
            Form2 FormCart = new Form2();
            FormCart.ShowDialog();
        }

       

        public void button_AddtoCart_Click(object sender, EventArgs e)
        {
            string name = combo_Goods.SelectedItem.ToString();
            string size = combo_size.SelectedItem.ToString();
            int quantity = Convert.ToInt32(numericUpDown1.Value);
            int price = Convert.ToInt32(text_price.Text);
            GoodsModel item = new GoodsModel(name, size, quantity, price);
            manager.AddtoCart(item);
            MessageBox.Show("Added to Cart");
            rownumbers += 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            text_price.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Value) * (items[combo_Goods.SelectedIndex].price));
        }
    }
}
