using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class GoodsManager
    {
        private static List<GoodsModel> _items;
        private static List<GoodsModel> _size;

        public GoodsManager()
        {
            _items = new List<GoodsModel>
            {
                new GoodsModel ("Jeans", 850),
                new GoodsModel ("Sweet", 900),
                new GoodsModel ("Top", 400),
                new GoodsModel ("Shirts", 270),
            };

            _size = new List<GoodsModel>
            {
                new GoodsModel("S"),
                new GoodsModel("M"),
                new GoodsModel("L"),
                new GoodsModel("XL"),
                new GoodsModel("XXL"),
            };
        }

        public List<GoodsModel> GetItems()
        {
            return _items;
        }

        public List<GoodsModel> GetSize()
        {
            return _size;
        }
    }
}
