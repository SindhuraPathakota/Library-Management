using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject13
{
    class Magazine : Book
    {
        public int IssueNumber { get; set; }
        public Magazine(string title, int pageCount, int issueNumber) : base( title, pageCount) {
            IssueNumber = issueNumber;
            MediaType = "Magazine";
        }
    }
}
