using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject13
{
    class Book : Media
    {
        public int PageCount { get; set; }
        public Book(string title,int pageCount) : base(title)  {
            PageCount = pageCount;
            MediaType = "Book";
        }
    }
}
