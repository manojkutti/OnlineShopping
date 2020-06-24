using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    class CourierCompany
    {
        public void OrderDelivery()
        {
            Console.WriteLine("We are getting your order ready to be shipped.");
        }
        public void Packing(string a)
        {
            Console.WriteLine("wrapping it as-{0}", a);
        }
    }
}
