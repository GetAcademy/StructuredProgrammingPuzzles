using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredProgrammingPuzzles
{
    internal class StringCompare
    {
        static void Demo()
        {
            var a = "Hal";
            var b = "Hallo";

            var compare = Compare(a, b);
        }

        private static int Compare(string a, string b)
        {
            var length = Math.Min(a.Length, b.Length);
            for (var i = 0; i < length; i++)
            {
                if (a[i] < b[i]) return -1;
                if (a[i] > b[i]) return 1;
            }
            if(a.Length<b.Length) return -1;
            if(a.Length>b.Length) return 1;
            return 0;
        }
    }
}
