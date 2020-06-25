using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    public class ShoppingCart
    {
        //Customer c = new Customer();
        MarketingStaff ms = new MarketingStaff();
        public List<Product> cart = new List<Product>();

        public void AddToCart()
        {
            Console.WriteLine("Enter the item id to add it to cart");
            int item = Convert.ToInt32(Console.ReadLine());

            if (ms.products.ContainsKey(item))
            {
                Product p = ms.GetProduct(item);
                cart.Add(p);
                Console.WriteLine("Items added to cart successfully");

            }
            else
            {
                Console.WriteLine("could not add to cart");
            }
        }
        public void ViewCart()
        {
            Console.WriteLine("The cart items are");
            if (cart.Count == 0)
            {
                Console.WriteLine("no items in the cart to display");
            }
            else
            {
                for (int i = 0; i < cart.Count; i++)
                {
                    Console.WriteLine(cart[i].ToString());
                }
            }
        }

        public void DeleteCart()
        {
            if (cart.Count != 0)
            {
                Console.WriteLine("Enter the product id to delete from cart");
                int id = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                for (int i = 0; i < cart.Count; i++)
                {
                    if (cart[i].GetId() == id)
                    {
                        Product p;
                        p = cart[i];
                        cart.Remove(p);
                        count++;
                        Console.WriteLine("Deleted successfully");
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Can't delete");
                }
            }
            else
            {
                Console.WriteLine("No items in the cart to delete");
            }
        }
        int totalcost = 0;
        public int GetTotalCost()
        {
            
            for (int i = 0; i < cart.Count; i++)
            {
                totalcost += cart[i].GetCost();
            }
            //Console.WriteLine(totalcost);
            return totalcost;
        }
    }
}
