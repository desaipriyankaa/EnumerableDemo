using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EnumerableDemo
{
    class Even : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            int i = 0;
            yield return i;
            while (true)
            {
                i += 2;
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
