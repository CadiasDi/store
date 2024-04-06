using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN 12312-31231", "D. Knuth", "Art of Progamming"),
            new Book(2,"ISBN 12312-31232", "M. Fowler", "Refactoring"),
            new Book(3,"ISBN 12312-31232", "B. Kernighan, D. Ritchie", "C Programming language"),
        };
    
        public Book[] GetAllByIsbn(string isbn) 
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }
        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                                    .ToArray();
        }

     }
}

