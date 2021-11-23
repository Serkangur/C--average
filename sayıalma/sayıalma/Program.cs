using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayıalma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir adet sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <sayi; i++)
            {
                toplam = toplam + i;  
                
            }
            
            double ortalama = toplam / sayi;
            if (ortalama>50)
            {
                
                Console.WriteLine("ortalamanız 50 den büyüktür");
                Console.ReadLine();
            }

            else
            {
               
                Console.WriteLine("ortalamanız 50 den büyük değildir");
                Console.ReadLine();
            }



        }
    }
}
