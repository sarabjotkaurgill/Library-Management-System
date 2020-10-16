using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public abstract class Media
    {
        static int nextSerialNumber = 0;
       // static int lent = 0;
        public string Title { get; set; }
        public string MediaType { get; set; }
        public int SerialNumber { get; set; }
        public int NoOfTimesLent { get; set; }
        public bool IndicateStatus { get; set; }
        public string MemberBorrowMedia { get; set; }

        public Media(string title, string mediatype)
        {
            Title = title;
            MediaType = mediatype;
            SerialNumber = nextSerialNumber++;
            //NoOfTimesLent = lent++;
            IndicateStatus = false;
        }

        public void ModifyFields(string newTitle, string newType)
        {
            Title = newTitle;
            MediaType = newType;
        }

        public virtual string MediaInfo()
        {
            return Title + " borrowed by " + MemberBorrowMedia + ". " +
                "Its serial number is " + SerialNumber;
        }
    }
}
