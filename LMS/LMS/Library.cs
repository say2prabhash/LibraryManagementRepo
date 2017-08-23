using LMS.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Library:ILibrary
    {
        public List<Books> BookCollection { get; set; }
        public Library()
        {
            BookCollection = new List<Books>();
        }
        public void AddBooksToLibrary(Books book)
        {
            BookCollection.Add(book);
        }
    }
}
