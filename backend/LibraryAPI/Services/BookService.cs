using LibraryAPI.Domain;
using LibraryAPI.EventHandlers;
using LibraryAPI.Models.Requests;
using LibraryAPI.Models.Responses;
using LibraryAPI.Repositories;

namespace LibraryAPI.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IEventHandler<AllCopiesUsedEvent> _eventHandler;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
        _eventHandler = new AllCopiesUsedEventHandler();
    }

    public async Task Rent(RentBookRequest request)
    {
        var book = await _bookRepository.GetByIdAsync(request.BookId);

        book.Rent();

        if (book.IsAllCopiesInUse())
        {
            await _eventHandler.Handle(new AllCopiesUsedEvent { BookId = request.BookId });
        }

        await _bookRepository.UpdateAsync(book);
        
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
                books = await _bookRepository.GetByISBNAsync(request.Value);
                break;
        }

        return new GetBookByParamsResponse(books);
    }
}