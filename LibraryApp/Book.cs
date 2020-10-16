using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Book : Media
    {
        public int PageCount { get; private set; }
        public Book(string title, string mediatype, int pageCount) : base(title, mediatype)
        {
            PageCount = pageCount;
        }

        public override string MediaInfo()
        {
            return base.MediaInfo()+ ". " + "Page Count is " + PageCount.ToString() + ". ";  
        }
    }
}
