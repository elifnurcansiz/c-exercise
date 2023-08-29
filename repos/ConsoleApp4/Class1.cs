using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{ 
    internal class Class1
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Görüntünün Genişliğini girin ");
            int genislik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Görüntünün Yüksekliğini Girin ");
            int yukseklik =Convert.ToInt32(Console.ReadLine());
            if (genislik > yukseklik) 
            {
                Console.WriteLine("Görüntü yatay(landscape) şekilde");
            }
            else if (yukseklik > 0) { Console.WriteLine("Görüntü portre(portrait) şekilde");
            }
            else {
                Console.WriteLine("Görüntü Kare Şeklinde ");
                    }
                }
    } 
}
