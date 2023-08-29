namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CsharpFundemantala\HelloWorld\HelloWorld.sln";
            var dotIndex= path.IndexOf('.');    
            var extension =path.Substring(dotIndex);
            Console.WriteLine("Extesion: " + Path.GetExtension(path));
            Console.WriteLine("File Name " + Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension" + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name" + Path.GetDirectoryName(path));
        }
    }
}