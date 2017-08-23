using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Contracts
{
    interface ILibrary
    {
        List<Books> BookCollection { get; set; }
        void AddBooksToLibrary(Books book);
    }
}
