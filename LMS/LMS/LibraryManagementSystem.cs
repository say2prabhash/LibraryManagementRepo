using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class LibraryManagementSystem : ILibraryManagementSystem
    {
        public List<Books> IssuedBookList { get; private set; }
        public LibraryManagementSystem()
        {
            IssuedBookList = new List<Books>();
        }
        public void IssueBooks(Books book, string issueTo)
        {
            book.IssuedTo = issueTo;
            IssuedBookList.Add(book);
        }
        public BookDescription ToString(Books book)
        {
            BookDescription bookInfo = new BookDescription();
            bookInfo.Author = book.Author;
            bookInfo.Name = book.Name;
            bookInfo.Genre = book.Genre;
            return bookInfo;
        }
    }
}
