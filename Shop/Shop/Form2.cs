﻿using System;
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
    public partial class Form2 : Form
    {
        private GoodsManager manager;
        public Form2()
        {
            InitializeComponent();
            manager = new GoodsManager();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "#";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Size";
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[4].Name = "Price";
            Form1 ff = new Form1();

            for (int i = 0; i < ff.cart.Count; i++)
            {
                dataGridView1.Rows.Add(i + 1, ff.cart[i].name, ff.cart[i].size, ff.cart[i].quantity, ff.cart[i].price);
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            

        }
    }
}
