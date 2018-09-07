using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class DistinctWordComparer : IEqualityComparer<Word>
    {
        public bool Equals(Word w1, Word w2)
        {
            return w1.Name == w2.Name && w1.Amount == w2.Amount;
        }

        public int GetHashCode(Word obj)
        {
            return obj.Name.GetHashCode() ^ obj.Amount.GetHashCode();
        }
    }
}
