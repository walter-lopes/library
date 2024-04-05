using LibraryAPI.Domain;

namespace LibraryAPI.Repositories;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetByAuthorAsync(string author);

    Task<IEnumerable<Book>> GetByISBNsync(string isbn);

    Task<IEnumerable<Book>> GetByCategoryAsync(string category);
}