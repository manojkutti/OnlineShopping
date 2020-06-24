using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    class MarketingStaff
    {
        public Dictionary<int, Product> products = new Dictionary<int, Product>()
        {
            {1, new Product(12,"Mi",100) },
            {2, new Product(34,"Samsung",1000) }
        };


        public void DisplayProducts()
        {
            Console.WriteLine("The Products are");
            foreach (KeyValuePair<int, Product> item in products)
            {
                Console.WriteLine(item.ToString());
            }

        }
        public Product GetProduct(int id)
        {
            Product p;
            p = products[id];
            return p;
        }
        public void UpdateProduct(int key, Product p)
        {
            //if (products.ContainsKey(key))
            //{
            //    products[key] = p;
            //    Console.WriteLine("Updated item successfully");
            //}
            //else
            //{
            //    products.Add(key, p);
            //}
            products[key] = p;
            Console.WriteLine("Updated item successfully");
        }
        public void DeleteProduct(int key)
        {
            products.Remove(key);
            Console.WriteLine("Item deleted successfully");
        }
        public void SendMail()
        {
            Console.WriteLine("Sent mail successfully");
        }
    }
}
