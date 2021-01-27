using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string CoverImage { get; set; }

    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 5, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 6, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 7, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 8, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 9, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 10, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 11, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 12, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 13, Title = "Vulpata", Author = "Futurum", CoverImage = "Assets/1.png" });

            return books;
        }
    }
}