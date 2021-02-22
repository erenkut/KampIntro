using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3]; /*{ "Engin", "Derin", "Salih" };*/
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";
            ///////
            string[] students2 = new [] { "Engin", "Derin", "Salih" };
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";
            ///////
            string[] students3 = { "Engin", "Derin", "Salih" };
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";
            //////
            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }

        }

        
                

        
        
    }
}
