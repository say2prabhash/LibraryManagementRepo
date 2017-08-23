using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    interface ILibraryManagementSystem
    {
        void IssueBooks(Books book,string issueTo);
        BookDescription ToString(Books book);
    }
}
