using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject13
{
    class LibraryMember
    {
       public string Name { get; set; }
       public LibraryMember(string name) {
            Name = name;
       }

        public override string ToString()
        {
            return Name;
        }

    }
}
