
class Book
{
    private string password = "secret";
}

class Program
{
    static void Main()
    {
        
        Book book = new Book();
        #region first question
        Console.WriteLine(book.password);
        // will not compile because password is private and cannot be accessed from outside the Book class
        #endregion
    }
}