namespace ConsoleApp4
{
    internal class Program
    {  
        static void Main(string[] args)

        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Lütfen 1 ile 10 arasında bir sayı giriniz");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi >= 1 && sayi <= 10)
                    {
                        Console.WriteLine("Geçerli");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Geçersiz bir giriş yaptınız lütfen bir sayı girin ");
                }
            }
                        
                }
        }
    }
