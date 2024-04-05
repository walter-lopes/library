using System.Data;
using Dapper;
using LibraryAPI.Domain;
using MySql.Data.MySqlClient;

namespace LibraryAPI.Repositories;

public class BookRepository : IBookRepository
{
    private readonly string _connectionString;

    public BookRepository(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public IDbConnection Connection => new MySqlConnection(_connectionString);

    public async Task<IEnumerable<Book>> GetByAuthorAsync(string author)
    {
        using var dbConnection = Connection;
        dbConnection.Open();
        var query = @"
                SELECT 
                book_id AS BookId, title, first_name AS FirstName, last_name AS LastName, total_copies AS TotalCopies, copies_in_use AS CopiesInUse, type, isbn, category, publisher
                FROM books 
                WHERE FirstName LIKE @FirstName 
                OR LastName LIKE @LastName
                OR (FirstName LIKE @FirstName AND LastName LIKE @LastName)";

        return await dbConnection.QueryAsync<Book>(query,
            new {FirstName = $"%{author}%", LastName = $"%{author}%"});
    }

    public async Task<IEnumerable<Book>> GetByCategoryAsync(string category)
    {
        using var dbConnection = Connection;
        dbConnection.Open();
        return await dbConnection.QueryAsync<Book>("SELECT book_id AS BookId, title, first_name AS FirstName, last_name AS LastName, total_copies AS TotalCopies, copies_in_use AS CopiesInUse, type, isbn, category, publisher FROM books WHERE Category = @category", new {Category = category});
    }
    
    public async Task<IEnumerable<Book>> GetByISBNAsync(string isbn)
    {
        using var dbConnection = Connection;
        dbConnection.Open();
        return await dbConnection.QueryAsync<Book>("SELECT book_id AS BookId, title, first_name AS FirstName, last_name AS LastName, total_copies AS TotalCopies, copies_in_use AS CopiesInUse, type, isbn, category, publisher FROM books WHERE Isbn = @isbn", new {Isbn = isbn});
    }
}