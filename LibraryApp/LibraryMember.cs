using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class LibraryMember
    {
        public string Name { get; set; }
        public LibraryMember(string name)
        {
            Name = name;
        }

        public void ModifyFields(string newName)
        {
            Name = newName;
        }

        public string MemberInfo()
        {
            return Name;
        }
    }
}
