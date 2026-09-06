
using FourthAssignment;

class Book
{
    private string password = "secret";
    internal int copiesInStock = 5;
    public string Title;
    public Genre Genre { get; set; }


}

class Program
{
    static void Main()
    {

        Book book = new Book();
        #region first question
       // Console.WriteLine(book.password);
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
        #region fourth question
        book.Genre = Genre.Science;

        Console.WriteLine(book.Genre);
        #endregion
        #region fifth question
        Console.WriteLine((int)Genre.Fiction);
        Console.WriteLine((int)Genre.NonFiction);
        Console.WriteLine((int)Genre.Science);
        #endregion
        #region sixth question
        int genreNumber = 1;
        Genre genre = (Genre)genreNumber;

        Console.WriteLine(genre);
        #endregion
        #region seventh question
        Genre genre2 = Genre.Fiction;

        string genreText = genre2.ToString();

        Console.WriteLine(genreText);
        #endregion
    }
}