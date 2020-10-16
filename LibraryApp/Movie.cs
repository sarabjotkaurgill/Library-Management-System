using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Movie : Media
    {
        public int RunTime { get; private set; }
        public Movie(string title, string mediaType, int runTime) : base(title, "Movie")
        {
            RunTime = runTime;
        }

        public override string MediaInfo()
        {
            return base.MediaInfo() + "Run Time is " + RunTime.ToString() + ". ";
        }
    }
}
