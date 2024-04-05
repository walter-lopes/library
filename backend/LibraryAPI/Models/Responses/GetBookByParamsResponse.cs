using LibraryAPI.Domain;

namespace LibraryAPI.Models.Responses;


public class GetBookByParamsResponse
{
    public GetBookByParamsResponse(IEnumerable<Book> books)
    {
        Items = books.Select(x => new GetBookByParamsItemResponse(x));
    }

    public IEnumerable<GetBookByParamsItemResponse> Items { get; set; }
}

public class GetBookByParamsItemResponse
{
    public GetBookByParamsItemResponse(Book book)
    {
        BookTitle = book.Title;
        Publisher = book.Publisher;
        Authors = book.GetAuthor();
        Type = book.Type;
        Isbn = book.Isbn;
        Category = book.Category;
        AvailableCopies = book.GetAvailableCopies();
    }
    public string BookTitle { get; set; }
    public string Publisher { get; set; }
    public string Authors { get; set; }
    public string Type { get; set; }
    public string Isbn { get; set; }
    public string Category { get; set; }
    public string AvailableCopies { get; set; }
}