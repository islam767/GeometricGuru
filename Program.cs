using System;

namespace GeometryGuru
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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

            


    
          {
          string qaytaBoshlash;
          do
         {
            Console.Clear();
            Console.WriteLine("=== GeometryGuru Menyusi ===");
            Console.WriteLine("1. Sonning darajasini hisoblash");
            Console.WriteLine("2. 1 dan N gacha tub sonlar yig'indisini topish");
            Console.Write("\nTanlang (1 yoki 2): ");
            string tanlov = Console.ReadLine();

            switch (tanlov)
            {
                case "1":
                    Console.Write("Asosni kiriting: ");
                    double asos = double.Parse(Console.ReadLine());
                    Console.Write("Darajani kiriting: ");
                    double daraja = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{asos}^{daraja} = {Math.Pow(asos, daraja)}");
                    break;

                case "2":
                    Console.Write("N sonini kiriting: ");
                    int n = int.Parse(Console.ReadLine());
                    int yigindi = 0;
                    for (int i = 2; i <= n; i++)
                    {
                        if (IsPrime(i)) yigindi += i;
                    }
                    Console.WriteLine($"1 dan {n} gacha bo'lgan tub sonlar yig'indisi: {yigindi}");
                    break;

                default:
                    Console.WriteLine("Noto'g'ri tanlov!");
                    break;
            }

            Console.Write("\nDasturni qayta boshlashni xohlaysizmi? (ha/yo'q): ");
            qaytaBoshlash = Console.ReadLine().ToLower();

           } while (qaytaBoshlash == "ha");
          }

           // Tub sonni aniqlash funksiyasi
          static bool IsPrime(int number)
          {
          if (number < 2) return false;
          for (int i = 2; i <= Math.Sqrt(number); i++)
           {
            if (number % i == 0) return false;
           }
            return true;
          }


    
          public static bool IsDigit(char character)
         {
         return character >= '0' && character <= '9';
         }
 
    
    public static void RunGeometryGuru(int choice)
    {
        switch (choice)
        {
            case 1: AddNumbers(); break;
            case 2: DivideNumber(); break;
            case 3: CalculateGeron(); break;
            default: Console.WriteLine("Yanlış seçim!"); break;
        }
    }

  
    public static int GetMax(int a, int b, int c)
    {
       
        return Math.Max(a, Math.Max(b, c));
    }

   
    public static long Factorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    
    public static int SumToN(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

   
    public static bool IsPrime(int number)
    {
        if (number < 2) return false;
        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    
    public static void CheckPassword()
    {
        int attempts = 0;
        while (attempts < 3)
        {
            Console.Write("Parolni kiriting: ");
            string input = Console.ReadLine();

            if (input == "admin123")
            {
                Console.WriteLine("Muvaffaqiyatli kirdingiz!");
                break; 
            }

            attempts++;
            if (attempts == 3)
            {
                Console.WriteLine("3 ta urinish tugadi!");
                break;
            }
        }
    }

    
     public static bool IsPalindrome(string word)
     {
        string reversed = "";
        word = word.ToLower(); 

      
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }

        return word == reversed;
     }

    
       static void AddNumbers() ;
       static void DivideNumber() ;   
       static void CalculateGeron();
       */

     {
        // 1. 1D Array asoslari
        int[] sonlar = new int[10];
        int yigindi = 0;
        Console.WriteLine("10 ta son kiriting:");
        for (int i = 0; i < 10; i++) {
            sonlar[i] = int.Parse(Console.ReadLine());
            yigindi += sonlar[i];
        }
        Console.WriteLine($"Elementlar yig'indisi: {yigindi}");

        // 2. Eng katta va eng kichik qiymat
        int max = sonlar.Max();
        int min = sonlar.Min();
        Console.WriteLine($"Eng katta: {max}, Eng kichik: {min}");

        // 3. Juft va toq sonlar
        Console.Write("Juft sonlar: ");
        foreach (var s in sonlar) if (s % 2 == 0) Console.Write(s + " ");
        
        Console.Write("\nToq sonlar: ");
        foreach (var s in sonlar) if (s % 2 != 0) Console.Write(s + " ");

        // 4. O‘rtacha qiymat
        double orta = (double)yigindi / sonlar.Length;
        Console.WriteLine($"\nO'rtacha qiymat: {orta}");
    }
    // STRING BILAN ISHLASH
          // 5. String teskari aylantirish

               Console.Write("\nSo'z kiriting: ");
               string matn = Console.ReadLine();
               char[] charArray = matn.ToCharArray();
               Array.Reverse(charArray);
               Console.WriteLine("Teskari: " + new string(charArray));

    // 6. Harflar sonini hisoblash (Lotin alifbosida)
       int unli = 0, undosh = 0;
       string unlilar = "aeuioo'i'a"; // O'zbek lotin unlilari
       foreach (char c in matn.ToLower()) {
      if (char.IsLetter(c)) {
          if (unlilar.Contains(c)) unli++;
          else undosh++;
       }
    }
Console.WriteLine($"Unli: {unli}, Undosh: {undosh}");

// 7. Palindrom tekshirish
    string teskari = new string(charArray);
      if (matn.ToLower() == teskari.ToLower()) 
          Console.WriteLine("Bu palindrom!");
      else 
       Console.WriteLine("Palindrom emas.");
    

 // 8. StringBuilder bilan birlashtirish
     StringBuilder gap = new StringBuilder();
     Console.WriteLine("5 ta so'z kiriting:");
     for (int i = 0; i < 5; i++)
    {
      gap.Append(Console.ReadLine()).Append(" ");
    }
    Console.WriteLine("Birlashgan gap: " + gap.ToString().Trim());

    // 9. Bo'sh joylarni olib tashlash
    string noSpace = matn.Replace(" ", "");
    Console.WriteLine("Bo'sh joylarsiz: " + noSpace);

    // 10. Ismlar Array + StringBuilder
     string[] ismlar = new string[5];
     StringBuilder sbIsmlar = new StringBuilder();
    Console.WriteLine("5 ta ism kiriting:");
    for (int i = 0; i < 5; i++) 
    {
    ismlar[i] = Console.ReadLine();
    sbIsmlar.Append(ismlar[i]);
    if (i < 4) sbIsmlar.Append(", ");
    }
   Console.WriteLine("Natija: " + sbIsmlar.ToString());


  }
     
 }
}
  
  




