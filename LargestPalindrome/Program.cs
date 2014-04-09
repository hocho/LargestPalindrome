using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var minLength = 3;

            // odd
            var data1 = "madamimadam";
            var p1 = FindLargestPalindrome(data1, minLength);

            // even
            var data2 = "abcdeedcba" ;
            var p2 = FindLargestPalindrome(data2, minLength);

            var data3 = "12345ablewasiereisawelba67890";
            var p3 = FindLargestPalindrome(data3, minLength);

            var data4 = "agfatgalkfjapsotgjimohomiqrotfasdnfl;asdfjopafadf[";
            var p4 = FindLargestPalindrome(data4, minLength);

            var data5 = "agfatgalkfjapsdfjopafgadfeve[";
            var p5 = FindLargestPalindrome(data5, minLength);

            var data6 = "xdadagfatgalkfjapsdfjopafgadfeve[";
            var p6 = FindLargestPalindrome(data6, minLength);

            var data7 = "agfatgalkfjapsdfjopafgadfeve";
            var p7 = FindLargestPalindrome(data7, minLength);

            var data8 = "dadagfatgalkfjapsdfjopafgadfeve[";
            var p8 = FindLargestPalindrome(data8, minLength);

            var data9 = "dadagfatgalkfimohomijapsdfjopafgadfeve[";
            var p9 = FindLargestPalindrome(data9, minLength);
        }

        static
        string 
        FindLargestPalindrome(
            string                              data,
            int                                 minLength)
        {
            int                                 length = data.Length;

            // test from max length to min length
            for (int size = length; size >= minLength; --size)
                // establish attempt bounds and test for the first palindrome substring of given size
                for (int attemptIdx = 0, attemptIdxEnd = length - size + 1;
                        attemptIdx < attemptIdxEnd;
                            ++attemptIdx)
                    if (IsPalindrome(data, attemptIdx, size))
                        return data.Substring(attemptIdx, size);

            return null;
        }

        static 
        bool
        IsPalindrome(
            string                              data,
            int                                 idxStart,
            int                                 count)
        {
            int                                 idxEnd = idxStart + count - 1;

            while (idxStart < idxEnd && data[idxStart] == data[idxEnd])
            {
                ++idxStart;
                --idxEnd;
            }

            return idxStart >= idxEnd;
        }
    }
}
