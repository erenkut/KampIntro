﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + product.productName);
        }

        public void Add2(string productName, string explanation, double price, int UnitsInStock)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + productName);
        }
    }
}
