CREATE TABLE IF NOT EXISTS books (
  book_id INT AUTO_INCREMENT PRIMARY KEY,
  title VARCHAR(100) NOT NULL,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  total_copies INT NOT NULL DEFAULT 0,
  copies_in_use INT NOT NULL DEFAULT 0,
  type VARCHAR(50),
  isbn VARCHAR(80) UNIQUE,
  category VARCHAR(50),
  publisher VARCHAR(50)
);

TRUNCATE books;

INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('Pride and Prejudice', 'Jane', 'Austen', 100, 80, 'Hardcover', '1234567891', 'Fiction', 'publisher');
