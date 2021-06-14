using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Found
    {
        public Int32? FoundMax2nd(Int32[] inputArray)
        {
            Int32 result = Int32.MinValue;
            Int32 N = 0;
                for (UInt32 index = 0; index < UInt32.MaxValue; ++index)
                    try
                    {
                        if (inputArray[index] == inputArray[index]) N++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
            if (N > 0)
            {
                var prev = Int32.MinValue;
                for (UInt32 index = 0; index < N; ++index)
                {
                    if (inputArray[index] > prev) prev = inputArray[index];

                }
                for (UInt32 index = 0; index < N; ++index)
                {
                    if (inputArray[index] > result && inputArray[index] != prev) result = inputArray[index];

                }
            }
            else return null;
            return result;
        }
    }
}
