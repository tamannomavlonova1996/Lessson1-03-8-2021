using System;
using System.Linq;

namespace Lessson1_03_8_2021
{
    class Program
    {
        static void Main(string[] args)
        { 
            // // 1таск
            // Console.Write("a=");
            // double a = Convert.ToDouble(Console.ReadLine());
            // Console.Write("b=");
            // double b = Convert.ToDouble(Console.ReadLine());
            // double result = Math.Round((Math.Sqrt(a * b)),2);
            // Console.WriteLine($"Result={result}");
            
            // // 2таск
            // Console.Write("A=");
            // double A = Convert.ToDouble(Console.ReadLine());
            // Console.Write("B=");
            // double B = Convert.ToDouble(Console.ReadLine());
            // Console.Write("C=");
            // double C = Convert.ToDouble(Console.ReadLine());
            // double distance_AC = Math.Round(Math.Abs(A-C),2);
            // double distance_BC = Math.Round((Math.Abs(B - C)),2);
            // double sumAC_BC = Math.Round((distance_AC + distance_BC),2); 
            // Console.WriteLine($"Distance_AC={distance_AC}");
            // Console.WriteLine($"Distance_BC={distance_BC}"); 
            // Console.WriteLine($"Summa_AC_BC={sumAC_BC}"); 
         
         // 3таск
         // Console.Write("x1=");
         // double x1 = Convert.ToDouble(Console.ReadLine());
         // Console.Write("y1=");
         // double y1 = Convert.ToDouble(Console.ReadLine());
         // Console.Write("x2=");
         // double x2 = Convert.ToDouble(Console.ReadLine());
         // Console.Write("y2=");
         // double y2 = Convert.ToDouble(Console.ReadLine());
         // double result =Math.Round(Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)),2);
         // Console.WriteLine($"Результат={result}");
         
         // 4таск
         /*Console.Write("Выведите двухзначное число: ");
         int number = Convert.ToInt32(Console.ReadLine());
         int result = ((number % 10) * 10) + number / 10;
         Console.WriteLine($"Результат = {result}");*/

         //5таск
         // Console.Write("Выведите число: ");
         // int N = Convert.ToInt32(Console.ReadLine());
         // int sec = 60;
         // int result = N / sec;
         // Console.WriteLine($"Результат={result}");
         
         // // 6таск
         Console.Write("Выведите число: ");
         int k = Convert.ToInt32(Console.ReadLine());;
         int result = k % 7;
         Console.WriteLine($"Результат={result}");
        }
    }
}
