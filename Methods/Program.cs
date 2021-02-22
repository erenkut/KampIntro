using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName1 = "Elma";
            double price1 = 15;
            string explanation1 = "Amasya elması";

            string[] fruits = new string[] { };

            Product product1 = new Product();
            product1.productName = "Elma";
            product1.price = 15;
            product1.explanation = "Amasya ELMA";

            Product product2 = new Product();
            product2.productName = "Karpuz";
            product2.price = 80;
            product2.explanation = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.productName);
                Console.WriteLine(product.price);
                Console.WriteLine(product.explanation);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("-------------Methods----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product1);

            sepetManager.Add2("Armut","Yeşil armut",12, 10);
            sepetManager.Add2("Elma","Yeşil elma",12, 9);
            sepetManager.Add2("Karpuz","Diyarbakır karpuzu",12, 8);

        }
    }
}
