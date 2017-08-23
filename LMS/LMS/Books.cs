using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Books : IBooks
    {
        public string Name { get; set; }
        public string IssuedTo { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
