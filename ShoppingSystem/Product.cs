﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public int ProductCost;
        public Product()
        {

        }

        public Product(int id, string name, int cost)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.ProductCost = cost;
        }

        public int GetId()
        {
            return ProductId;
        }
        public void SetId(int id)
        {
            this.ProductId = id;
        }
        public int GetCost()
        {
            return ProductCost;
        }
        public void SetCost(int cost)
        {
            this.ProductCost = cost;
        }
        public override string ToString()
        {
            return "" + ProductId + " " + ProductName + " " + ProductCost;
        }
    }
}
