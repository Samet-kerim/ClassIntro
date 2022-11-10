using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {   //naming convetion
        //sytax
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi" + product.Adi);
        }
    }
}
