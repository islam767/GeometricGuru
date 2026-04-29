using System;
public class tortburchakyuzi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tortburchak yuz hisoplash");
            Console.WriteLine("-------------");

            Console.Write("tortburchakni uzunligini kiriting (metr): ");
            double uzunlik = Convert.ToDouble(Console.ReadLine());

            Console.Write("tortburchakni kengligini kiriting (metr): ");
            double kenglik = Convert.ToDouble(Console.ReadLine());

            double yuza = uzunlik * kenglik;

            Console.WriteLine($"\nNatija: tort burchakni yuzi {yuza} teng.");
            
            Console.ReadKey();
        }
    }
}
