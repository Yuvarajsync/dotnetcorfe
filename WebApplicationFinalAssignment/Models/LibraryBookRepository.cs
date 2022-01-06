using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFinalAssignment.Data;

namespace WebApplicationFinalAssignment.Models
{
    public class LibraryBookRepository : ILibraryBookRepository
    {
        private readonly BookDbContext _db;

        public LibraryBookRepository(BookDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Books> ListBooks()
        {
            IList<Books> listofbooks = new List<Books>();

            var query = from Book in _db.Book select Book;
            var books = query.ToList();
            foreach(var Bookdata in books)
            {
                listofbooks.Add(new Books()
                {
                    BookId = Bookdata.BookId,
                    BookName = Bookdata.BookName,
                    AuthorName = Bookdata.AuthorName,
                    PublisherYear = Bookdata.PublisherYear,
                    Price = Bookdata.Price,
                    UpdatedOn = Bookdata.UpdatedOn
                });
            }
            return listofbooks;
        }
    }
}
