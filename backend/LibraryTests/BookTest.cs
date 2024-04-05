using LibraryAPI.Domain;

namespace LibraryTests;

public class Tests
{
    [Test]
    public void Should_Return_Author()
    {
        var book = new Book()
        {
            FirstName = "Paulo",
            LastName = "Coelho"
        };

        Assert.AreEqual(book.GetAuthor(), "Paulo Coelho");
    }
    
    [Test]
    public void Should_Return_AvailableCopies()
    {
        var book = new Book()
        {
            CopiesInUse = 1,
            TotalCopies = 200
        };

        Assert.AreEqual(book.GetAvailableCopies(), "1/200");
    }
}