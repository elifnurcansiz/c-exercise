namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog poat blah blah blah...";
            var shortenedPost = post.Shorten(5);
        }
    } 
}