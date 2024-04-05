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
VALUES ('Pride and Prejudice', 'Jane', 'Austen', 100, 80, 'Hardcover', '1234567891', 'Fiction', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('To Kill a Mockingbird', 'Harper', 'Lee', 75, 65, 'Paperback', '1234567892', 'Fiction', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('The Catcher in the Rye', 'J.D.', 'Salinger', 50, 45, 'Hardcover', '1234567893', 'Fiction', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('The Great Gatsby', 'F. Scott', 'Fitzgerald', 50, 22, 'Hardcover', '1234567894', 'Non-Fiction', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('The Alchemist', 'Paulo', 'Coelho', 50, 35, 'Hardcover', '1234567895', 'Biography', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('The Book Thief', 'Markus', 'Zusak', 75, 11, 'Hardcover', '1234567896', 'Mystery', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('The Chronicles of Narnia', 'C.S.', 'Lewis', 100, 14, 'Paperback', '1234567897', 'Sci-Fi', "Publisher";


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('The Da Vinci Code', 'Dan', 'Brown', 50, 40, 'Paperback', '1234567898', 'Sci-Fi', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('The Grapes of Wrath', 'John', 'Steinbeck', 50, 35, 'Hardcover', '1234567899', 'Fiction', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('The Hitchhiker''s Guide to the Galaxy', 'Douglas', 'Adams', 50, 35, 'Paperback', '1234567900', 'Non-Fiction', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('Moby-Dick', 'Herman', 'Melville', 30, 8, 'Hardcover', '8901234567', 'Fiction', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('To Kill a Mockingbird', 'Harper', 'Lee', 20, 0, 'Paperback', '9012345678', 'Non-Fiction', "Publisher");


INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category, publisher)
VALUES ('The Catcher in the Rye', 'J.D.', 'Salinger', 10, 1, 'Hardcover', '0123456789', 'Non-Fiction', "Publisher");