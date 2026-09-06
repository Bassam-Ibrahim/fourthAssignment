
class Book
{
    private string password = "secret";
    internal int copiesInStock = 5;
    public string Title;


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
        #region second question
        Console.WriteLine(book.copiesInStock);
        //will compile because it is  internal and can be accessed from the same poject
        #endregion
        #region third question

        book.Title = "C# Basics";

        Console.WriteLine(book.Title);
        #endregion
    }
}