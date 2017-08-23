using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    interface IBooks
    {
        string Name { get; set; }
        string Author { get; set; }
        string IssuedTo { get; set; }
        string Genre { get; set; }
    }
}
