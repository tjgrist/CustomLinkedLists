using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedLists
{
    class SystemString : ICustomString
    {
        string myString;

        public SystemString(string name)
        {
            myString = name;
        }
        public override string ToString()
        {
            return myString;
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            myString = myString.Insert(startIndex, stringToInsert);
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            myString = myString.Remove(startIndex, numCharsToRemove);
        }

        public int Length()
        {
            return myString.Length;
        }
    }
}
