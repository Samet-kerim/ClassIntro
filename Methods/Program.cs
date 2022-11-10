using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {   // Dont repeat yourself -DRY
            // Clean code
            // Best Practice (Doğru uygulama teknikleri)
            // Class isimlendirmesi PascalCase yazılır

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Dıyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };
            // type safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("---------Metodlar-----------");


            // instance --örnek
            // encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

        }
    }
}
