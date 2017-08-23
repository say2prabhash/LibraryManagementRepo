using LMS.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class BookDescription : IBookDescription
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
    }
}
