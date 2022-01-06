using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFinalAssignment.Models
{
    public interface ILibraryBookRepository
    {
        IEnumerable<Books> ListBooks();
    }
}
