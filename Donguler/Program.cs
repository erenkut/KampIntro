using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "Yazılım geliştirici yetiştirme kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java"
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            //string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java";

            for (int i = 1; i < 100000000; i++)
            {
                Console.WriteLine(i);

            }
        }
    }
}
