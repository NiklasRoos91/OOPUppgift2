namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dvd dvd1 = new Dvd
            {
                AuthorOrDirector = "Steven"
            };

            Console.WriteLine($"DVD Director: {dvd1.AuthorOrDirector}");
        }
    }
}
