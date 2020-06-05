using System.Collections.Generic;
using System.Linq;

namespace ProperNameFormattingLibrary
{
    class FirstFirst : ProperNameFormattingClass
    {
        public FirstFirst(string name)
        {
            char[] separators = new char[] { ' ' };
            List<string> nameList = name.Split(separators).ToList();
            int i = name.IndexOf(" ");
            if (i > 0)
            {
                // this.FirstName = name.Substring(0, i).Trim();
                // this.LastName = name.Substring(i+1).Trim();

                this.LastName = nameList.Last<string>().Trim(); ;
                nameList.RemoveAt(nameList.Count - 1);

                for (int ptr = 0; ptr < nameList.Count-1; ptr++)
                {
                    if (ptr > 0)
                    {
                        this.FirstName += " ";
                    }

                    this.FirstName += nameList[ptr].Trim();
                }
            }
            else
            {
                this.FirstName = "";
                this.LastName = name;
            }
        }
    }

}


