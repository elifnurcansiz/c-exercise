namespace ArdısıkKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kısa Çizgiyle Ayrılmış birkaç sayı giriniz");
            string inputNumbers = Console.ReadLine();
            string[] numDizisi = inputNumbers.Split('-');
            bool ardisilMi = true;
            for (int i = 1;  i <= numDizisi.Length; i++)
            {
                if (Convert.ToInt32(numDizisi[i]) != Convert.ToInt32(numDizisi[i - 1]) + 1);
                    {
                ardisilMi = false;
                break}
            }
            if (ardisilMi)
            {
                Console.WriteLine("Ardışık");
            }
            else {
                Console.WriteLine("Ardışık Değil");
            }
        }

       
    }
}