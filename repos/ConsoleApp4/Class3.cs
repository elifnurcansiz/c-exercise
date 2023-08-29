using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class3
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hız limit giriniz: ");
            int hizLimiti = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aracın Hızını Giriniz");
                int aracHizi = Convert.ToInt32(Console.ReadLine());
            if (aracHizi <= hizLimiti) {
                Console.WriteLine("Tamam");
            }
            else
            {
                int demeritNoktalari = (aracHizi - hizLimiti) / 5;
                if (demeritNoktalari > 12)
                {
                    Console.WriteLine("Ehliyet Askıya Alındı");
                }
                else { Console.WriteLine("$Demerit Noktaları: {demeritNoktaları");
                }
            }
        } } }
