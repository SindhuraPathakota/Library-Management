using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject13
{
    class Movie : Media
    {
        public float RunTime { get; set; }

        public Movie(string title,float runTime) : base( title)
        {
            RunTime = runTime;
            MediaType = "Movie";
        }
    }
}
