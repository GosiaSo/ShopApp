using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name => FirstName + " " + LastName;
        public string Address { get; set; }

        private List<Item> items = new List<Item>();

        public List<Item> Items
        {
            get
            {
                // Copy of original "items" collection
                return new List<Item>(items);
            }
        }

        internal void AddItem(Item item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            items.Add(item);
        }

        internal void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        internal void RemoveItemById(int id)
        {
            foreach (Item tmp in items)
            {
                if (tmp.ItemId == id)
                {
                    items.Remove(tmp);
                    return;
                }
            }
        }

        internal Client(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }
}
