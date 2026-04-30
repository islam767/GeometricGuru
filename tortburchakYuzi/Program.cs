using System;

namespace GeometryGuru
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Birinci sayıyı girin (a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("İkinci sayıyı girin (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qo'shish: " + (a + b));
            Console.WriteLine("Ayirish: " + (a - b));
            Console.WriteLine("Ko'paytirish: " + (a * b));
            Console.WriteLine("Bo'lish: " + (a / b));
            Console.WriteLine("--------------------------------\n");


            // --- TORTBURCHAK XISOPLASH
            Console.WriteLine("Tortburchak yuz hisoplash");
            Console.WriteLine("--------------");

            Console.Write("tortburchakni uzunligini kiriting (metr): ");
            double uzunlik = Convert.ToDouble(Console.ReadLine());

            Console.Write("tortburchakni kengligini kiriting (metr): ");
            double kenglik = Convert.ToDouble(Console.ReadLine());

            double yuz = uzunlik * kenglik;

            Console.WriteLine("----------------");
            Console.WriteLine("Tortburchakning yuzi: " + yuz + " kv metr");

            // Programın kapanmasını engellemek için
            Console.WriteLine("\nChiqish uchun bir tugmaga bosing...");
            Console.ReadKey();
        }
    }
}