using System;

namespace GeometryGuru
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write(" 1- sonni kiriting (a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write(" 2 sonni kiriting (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qo'shish: " + (a + b));
            Console.WriteLine("Ayirish: " + (a - b));
            Console.WriteLine("Ko'paytirish: " + (a * b));
            Console.WriteLine("Bo'lish: " + (a / b));
            Console.WriteLine("--------------------------------\n");


            // --- TORTBURCHAK XISOPLASH
            Console.WriteLine("Tortburchak yuzini hisoplash");
            Console.WriteLine("--------------");

            Console.Write("tortburchakni uzunligini kiriting (metr): ");
            double uzunlik = Convert.ToDouble(Console.ReadLine());

            Console.Write("tortburchakni kengligini kiriting (metr): ");
            double kenglik = Convert.ToDouble(Console.ReadLine());

            double yuz = uzunlik * kenglik;

            Console.WriteLine("----------------");
            Console.WriteLine("Tortburchakning yuzi: " + yuz + " kv metr");

            
            Console.WriteLine("\nChiqish uchun bir tugmaga bosing...");
            Console.ReadKey();
            



            Console.WriteLine("--- GeometryGuru Amallar Menusi ---");
            Console.WriteLine("1. Qo'shish (+)");
            Console.WriteLine("2. Ayirish (-)");
            Console.WriteLine("3. Ko'paytirish (*)");
            Console.WriteLine("4. Bo'lish (/)");
            Console.Write("\nBajarmoqchi bo'lgan amalingizni tanlang (1-4): ");

            int tanlov = Convert.ToInt32(Console.ReadLine());
             
  
            //2 Kirish qismi
            Console.WriteLine("=== GEOMETRY GURU  ===");
            Console.WriteLine("1. Oddiy arifmetika (+, -, *, /)");
            Console.WriteLine("2. Chuqur (hovuz) hajmini hisoblash");
            Console.Write("\nTanlovingizni kiriting (1 yoki 2): ");
            string asosiyTanlov = Console.ReadLine();

            // 1-YO'L: Oddiy Arifmetika
            if (asosiyTanlov == "1")
            {
                Console.Write("Amalni kiriting (+, -, *, /): ");
                string amal = Console.ReadLine();

                Console.Write("1-sonni kiriting: ");
                double s1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2-sonni kiriting: ");
                double s2 = Convert.ToDouble(Console.ReadLine());

                // Hisoblash mantiqi
                if (amal == "+")
                {
                    Console.WriteLine("Natija: " + (s1 + s2));
                }
                else if (amal == "-")
                {
                    Console.WriteLine("Natija: " + (s1 - s2));
                }
                else if (amal == "*")
                {
                    Console.WriteLine("Natija: " + (s1 * s2));
                }
                else if (amal == "/")
                {
                    // Sening asosiy sharting: 0 ga bo'lishni tekshirish
                    if (s2 == 0)
                    {
                        Console.WriteLine("Xatolik: 0 ga bo'lish mumkin emas!");
                    }
                    else
                    {
                        Console.WriteLine("Natija: " + (s1 / s2));
                    }
                }
                else
                {
                    Console.WriteLine("Noto'g'ri amal kiritildi!");
                }
            }
            // 2-YOL: Chuqur hajmi
            else if (asosiyTanlov == "2")
            {
                Console.WriteLine("\n--- Chuqur hajmini hisoblash ---");
                Console.Write("Uzunlik (metr): ");
                double u = Convert.ToDouble(Console.ReadLine());

                Console.Write("Eni (metr): ");
                double e = Convert.ToDouble(Console.ReadLine());

                Console.Write("Chuqurlik (metr): ");
                double h = Convert.ToDouble(Console.ReadLine());

                // Hajm m3 da
                double hajm = u * e * h;
                // Litrga o'tkazish
                double litr = hajm * 1000;

                Console.WriteLine("\n----------------------------");
                Console.WriteLine($"Chuqur hajmi: {hajm} m3");
                Console.WriteLine($"Ichiga sig'adigan suv: {litr} litr");
                Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine("notugri  tanlov ");
            }

            



        }
    }
}