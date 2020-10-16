using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Magazine : Book
    {
        public int IssueNumber { get; private set; }
        public Magazine(string title, string mediatype, int pageCount, int issueNumber) : base(title, mediatype, pageCount)
        {
            IssueNumber = issueNumber;
        }

        public override string MediaInfo()
        {
            return base.MediaInfo() + ". " + "Issue Number is " + IssueNumber.ToString() + ". ";
        }
    }
}
