using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laboratorio_1
{
    public class Products
    {

        Products products = new Products();
        Products Id = new Products();
        Products Precio = new Products();
        Products Stock = new Products();

        public Products(Products producto, Products id, Products precio, Products stock)
        {
            products = producto;
            Id = id;
            Precio = precio;
            Stock = stock;
        }

        static void main(string[] args)
        {
            while (true)
            {
                try
                {

                }
                catch
                {

                } 
            }
            
        }



    }
}
