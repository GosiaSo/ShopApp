using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShopLib
{
    public class Item
    {
        static int nextId;
        public int ItemId { get; private set; }

        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public uint Amount { get; set; }

        public decimal Subtotal => UnitPrice * Amount;

        public override string ToString()
        {
            return string.Format("{0}. {1}, amount: {2}, price: {3}",
                ItemId, ProductName, Amount, Subtotal);
        }

        public Item()
        {
            ItemId = GenerateId();
        }

        public Item(string name, decimal price)
        {
            ItemId = GenerateId();
            ProductName = name;
            UnitPrice = price;
            Amount = 1;
        }

        public Item(string name, decimal price, uint amount)
        {
            ItemId = GenerateId();
            ProductName = name;
            UnitPrice = price;
            Amount = amount;
        }

        protected static int GenerateId()
        {
            // http://stackoverflow.com/a/9262259/1442833
            return Interlocked.Increment(ref nextId);
        }
    }
}
