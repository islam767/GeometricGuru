using System;

namespace GeometryGuru
{
  class Program
  {

  
    static void Main()
     {
        // Sonlarni belgilaymiz
       double a = Convert.ToInt32(Console.ReadLine());
       double b = Convert.ToInt32(Console.ReadLine());

       // Natijalarni ekranga chiqaramiz
       Console.WriteLine("Qo'shish: " + (a + b));
       Console.WriteLine("Ayirish: " + (a - b));
       Console.WriteLine("Ko'paytirish: " + (a * b));
       Console.WriteLine("Bo'lish: " + (a / b));
     }
  }
    
}
