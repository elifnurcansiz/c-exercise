using System.Security.Cryptography.X509Certificates;

namespace Customer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}