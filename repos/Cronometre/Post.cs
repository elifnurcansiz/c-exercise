using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronometre
{
    class Post
    { public string Title { get; }
        public string Explanation { get; }
        public DateTime OlusturmaTarihi { get; }
        private int oySayisi;
        public Post(string title , string explanation)
        {
            Title = title;
            Explanation= explanation;
            OlusturmaTarihi= DateTime.Now;
            oySayisi = 0;


        }
        public void OlumluOyVer()
        {
            oySayisi++;
        }
        public void OlumsuzOyVer()
        { oySayisi--; }
        public int OySayisiGoruntule()
        {
            return oySayisi;
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            // bir gönderi oluştur
            Post gonderi = new Post("Örnek Gönderi ", "Bu bir örnek Stackoverflow gösterisidir");
            gonderi.OlumluOyVer();
            gonderi.OlumluOyVer();
            gonderi.OlumsuzOyVer();
            Console.WriteLine("Mevcut Oy sayisi :  " + gonderi.OySayisiGoruntule);

        }
    }   
}
