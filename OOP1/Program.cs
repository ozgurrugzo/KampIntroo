﻿using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //bu şekilde de yazabilirdik yukarıdaki kod satırını:
            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName="Kalem",UnitsInStock=5, UnitPrice=35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            


        }
    }
}
