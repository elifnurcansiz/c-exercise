using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            Console.WriteLine(builder);
            builder.AppendLine();
            builder.Append("Header");    
            builder.AppendLine();   
            builder.Append('-',10);
            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder .Insert (0,new string'-',10));
            Console.WriteLine(builder);
        }
    }
}