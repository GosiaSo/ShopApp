using System;
using ShopLib;

namespace ShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Client client1 = shop.RegisterClient("Jan", "Kowalski",
                                                 "jk@example.com");
            shop.AddItem(client1, new Item
            {
                ProductName = "Wireless Keyboard",
                UnitPrice = 89.90m,
                Amount = 2
            });
            shop.AddItem(client1, new Item("Wireless Mouse", 44.90m));

            Display(shop, client1);

            shop.RemoveItemById(client1, 1);

            Display(shop, client1);

            Console.ReadLine();
        }

        private static void Display(Shop shop, Client client)
        {
            Console.WriteLine("Client: " + client.Name);
            foreach (Item item in client.Items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Total: " + shop.TotalPriceFor(client));
            Console.WriteLine();
        }
    }
}
