using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public internal interface IBookRepository 
    {
        Book[] GetByAllTitle(string titlePart);
    }
}
