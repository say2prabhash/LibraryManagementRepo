using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Contracts
{
    interface IBookDescription
    {
        string Author { get; set; }
        string Name { get; set; }
        string Genre { get; set; }
    }
}
