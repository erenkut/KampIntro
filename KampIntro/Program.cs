using System;

namespace KampIntro
{
    class Program
    {
       static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";  //yazısal veriler.
            int ogrenciSayısı = 32000;               //sayısal veriler.
            double faizOranı = 1.45;                 //ondalıklı sayılar.
            bool sistemeGirisYamısMi = true;         //true-false seçeneği 

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYamısMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);


        }
    }
}
