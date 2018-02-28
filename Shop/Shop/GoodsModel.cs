using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class GoodsModel
    {
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string size { get; set; }

        public GoodsModel(string _name, double _price)
        {
            name = _name;
            price = _price;
        }
        
        public GoodsModel(string _size)
        {
            size = _size;
        }

        public GoodsModel(string _name, string _size, int _quantity, int _price)
        {
            name = _name;
            size = _size;
            quantity = _quantity;
            price = _price;
        }
    }
}
