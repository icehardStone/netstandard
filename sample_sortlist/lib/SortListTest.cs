using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace sample_sortlist
{
    public class SortListTest
    {
        public void Test()
        {
            SortedList<string, string> list = new System.Collections.Generic.SortedList<string,string>(new SortComparer());
            SortedList<string,string> list2 = new SortedList<string, string>();

            list.Add("1","admas");
            list.Add("233","lily");
            // list.Add("234","yulin");
            list.Add("11","tomas");

            list2.Add("ice","cold");
            list2.Add("rain","water");
            list2.Add("wind","grain");

            // list.Comparer = new SortComparer();
        }
    }
    public class SortComparer : IComparer<string>
    {
        public int Compare([AllowNull] string x, [AllowNull] string y)
        {
            // throw new NotImplementedException();
            if(x.Length == y.Length) return 0;
            else if(x.Length > y.Length) return 1;
            else return -1;
        }
    }
}