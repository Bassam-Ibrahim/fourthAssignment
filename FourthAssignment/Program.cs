
class Book
{
    private string password = "secret";
}

class Program
{
    static void Main()
    {
        
        Book book = new Book();

        Console.WriteLine(book.password);
        // will not compile because password is private and cannot be accessed from outside the Book class
    }
}