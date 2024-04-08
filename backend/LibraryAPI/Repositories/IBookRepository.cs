using LibraryAPI.Domain;

namespace LibraryAPI.Repositories;

public interface IBookRepository
{
    Task UpdateAsync(Book book);
    
    Task<Book> GetByIdAsync(int id);
    
    Task<IEnumerable<Book>> GetByAuthorAsync(string author);

    Task<IEnumerable<Book>> GetByISBNAsync(string isbn);

    Task<IEnumerable<Book>> GetByCategoryAsync(string category);
}