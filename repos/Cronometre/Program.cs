namespace Cronometre
{
    class Cronometresssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssmadan Durdurulamaz");
            }
            stopTime = DateTime.Now;
            isRunning = false;
        }
        public TimeSpan GecenSure
        {
            get
            {
                if (isRunning)
                {
                    throw new InvalidOperationException("Kronometre Hala Çalışıyor");

                }
                return stopTime - startTime;
            }
        } 
        class Program
        {

        }
        static void Main(string[] args)
        {
            Cronometre cronometre = new Cronometre();
            cronometre.Start();
            Console.WriteLine("Krronometre başlatıldı. Durdurmak için herhangi bir tuşa basın...");
            Console.ReadKey();
            cronometre.Stop();
            Console.WriteLine("Kronometre Durduruldu . Devam etmek için herhangi bir tuşa basın...");
            Console.ReadKey();
            cronometre.Start();
            Console.WriteLine("Krnometre tekrar başlatıldı.Durdurmak için herhangi bir tuşa basın...");
            Console.ReadKey();
            cronometre.Stop();
            Console.WriteLine("Kronometre durudurldu. Toplam Geçen Süre: +kronometre.GecenSure ");
        }
    }
}