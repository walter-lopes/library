using LibraryAPI.Domain;
using LibraryAPI.Models.Responses;

namespace LibraryTests;

public class GetBookByParamsResponseTest
{
    [Test]
    public void Constructor_InitializesItems_WithCorrectValues()
    {
        // Arrange
        var books = new List<Book>
        {
            new Book
            {
                Title = "Book Title 1",
                Publisher = "Publisher 1",
                Type = "Type 1",
                Isbn = "ISBN1",
                Category = "Category 1",
                FirstName  = "Paulo",
                LastName  = "Coelho",
                CopiesInUse  = 1,
                TotalCopies  = 200
            },
            new Book
            {
                Title = "Book Title 2",
                Publisher = "Publisher 2",
                Type = "Type 2",
                Isbn = "ISBN2",
                Category = "Category 2",
                FirstName  = "J r r",
                LastName  = "Martin",
                CopiesInUse  = 1,
                TotalCopies  = 50
            }
        };

        // Act
        var response = new GetBookByParamsResponse(books);

        // Assert
        Assert.AreEqual(2, response.Items.Count());
        Assert.AreEqual("Book Title 1", response.Items.First().Title);
        Assert.AreEqual("Paulo Coelho", response.Items.First().Authors); 
        Assert.AreEqual("1/200", response.Items.First().AvailableCopies); 
        
        
        Assert.AreEqual("Book Title 2", response.Items.Last().Title);
        Assert.AreEqual("J r r Martin", response.Items.Last().Authors);
        Assert.AreEqual("1/50", response.Items.Last().AvailableCopies); 
    }
}