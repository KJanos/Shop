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

        public Form1()
        {
            InitializeComponent();

            manager = new GoodsManager();
            items = manager.GetItems();
            size = manager.GetSize();

            for (int i = 0; i < items.Count; i++)
            {
                combo_Goods.Items.Add(items[i].name);
                combo_size.Items.Add(size[i].size);
                
            }
            
            
        }

        private void combo_Goods_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_price.Text = Convert.ToString(items[combo_Goods.SelectedIndex].price);
        }
    }
}
