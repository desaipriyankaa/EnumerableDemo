using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EnumerableDemo
{
    class Even : IEnumerable<int>
    {
        public IEnumerator GetEnumerator()
        {
            int i = 0;
            yield return i;
            while (true)
            {
                i += 2;
                yield return i;
            }
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
