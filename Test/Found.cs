using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class Found<T> where T : struct, IComparable
    {
        public T? FoundMax2nd(ICollection<T> inputArray)
        {
            try
            {
                T prev = inputArray.ElementAt(0);
                T result = inputArray.ElementAt(0);
                Boolean check = false;

                foreach (T index in inputArray)
                {
                    if (index.CompareTo(prev) > 0)
                    {
                        prev = index;
                    }
                }

                foreach (T index in inputArray)
                {
                    if (index.CompareTo(result) >= 0 && !index.Equals(prev)) { result = index; check = true; }
                }

                if (check)
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
