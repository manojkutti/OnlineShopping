using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    public class CourierCompany
    {
        
        public void OrderDelivery()
        {
            //SalesStaff sta = new SalesStaff();
            ////od= custo.b;
            //if (sta.bee)
            //{
            //    Console.WriteLine("We are getting your order ready to be shipped.");
            //}
            //else
            //{
            //    Console.WriteLine("First place d order to check status");
            //}
            Console.WriteLine("on d way");
        }
        
        public void Packing(string a)
        {
            Console.WriteLine("wrapping it as-{0}", a);
        }

        public void Delivery()
        {
            Console.WriteLine("Ready to be shipped");
        }
    }
}
