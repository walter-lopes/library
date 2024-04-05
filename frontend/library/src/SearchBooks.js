// src/SearchBooks.js
import React, { useState } from 'react';

const SearchBooks = () => {
  const [filter, setFilter] = useState('author'); // Default search filter
  const [query, setQuery] = useState('');
  const [books, setBooks] = useState([]);

  const searchBooks = async (e) => {
    e.preventDefault();
    const apiUrl = `http://localhost:5000/Books/${filter}/${query}`;
    try {
      const response = await fetch(apiUrl);
      const data = await response.json();
      setBooks(data.items); // Adjust based on your API's response structure
    } catch (error) {
      console.error('Failed to fetch books:', error);
    }
  };

  return (
    <div>
      <form onSubmit={searchBooks}>
        <select value={filter} onChange={(e) => setFilter(e.target.value)}>
          <option value="author">Author</option>
          <option value="isbn">ISBN</option>
          <option value="category">Category</option>
        </select>
        <input
          type="text"
          value={query}
          onChange={(e) => setQuery(e.target.value)}
          placeholder={`Search by ${filter}`}
        />
        <button type="submit">Search</button>
      </form>
      <div>
        {books.length > 0 && (
          <table>
            <thead>
              <tr>
                <th>Title</th>
                <th>Publisher</th>
                <th>Authors</th>
                <th>Type</th>
                <th>ISBN</th>
                <th>Category</th>
                <th>Available Copies</th>
              </tr>
            </thead>
            <tbody>
              {books.map((book, index) => (
                <tr key={index}>
                  <td>{book.title}</td>
                  <td>{book.publisher}</td>
                  <td>{book.authors}</td>
                  <td>{book.type}</td>
                  <td>{book.isbn}</td>
                  <td>{book.category}</td>
                  <td>{book.availableCopies}</td>
                </tr>
              ))}
            </tbody>
          </table>
        )}
      </div>
    </div>
  );
};

export default SearchBooks;
