using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject13
{
    abstract class Media
    {
        public string Title { get; set; }
        public string MediaType { get; set; }
        public int SerialNum { get; private set; } = 0;
        public int NoOfTimesBorrowed { get; set; }
        public bool Availability { get; set; } = true;
        public string WhoBorrowed { get; set; }

        static int count = 0;
        public Media(string title) {
            Title = title;
            SerialNum=++count;
            NoOfTimesBorrowed = 0;
            WhoBorrowed = null;
        }
    }
}
