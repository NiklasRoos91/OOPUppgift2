namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librarian librarian1 = new Librarian();

            librarian1.ReturnItem();
            librarian1.BorrowItem();
        }
    }
}
