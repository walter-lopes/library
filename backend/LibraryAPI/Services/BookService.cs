using LibraryAPI.Domain;
using LibraryAPI.Models.Requests;
using LibraryAPI.Models.Responses;
using LibraryAPI.Repositories;

namespace LibraryAPI.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<GetBookByParamsResponse> GetBooksByParams(GetBooksByParamsRequest request)
    {
        IEnumerable<Book> books;
        
        switch (request.Filter)
        {
            case Filter.Author:
                books = await _bookRepository.GetByAuthorAsync(request.Value);
                break;
            case Filter.Category:
                books = await _bookRepository.GetByCategoryAsync(request.Value);
                break;
            default:
                books = await _bookRepository.GetByISBNsync(request.Value);
                break;
        }

        return new GetBookByParamsResponse(books);
    }
}