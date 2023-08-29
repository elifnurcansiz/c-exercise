namespace Abstract
{
    public class Shape 
    {
        public int Widht { get; set; }
        public int Height { get; set; }
        public virtual void Draw()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}