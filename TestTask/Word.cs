using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Word : IComparable<Word>,IEquatable<Word>
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public int CompareTo(Word word)
        {
            if (word == null)
                return 1;
            else
                return this.Name.CompareTo(word.Name);
        }

        public bool Equals(Word w)
        {
            if(w == null || GetType() != w.GetType())
                return false;

            Word word = (Word)w;

            return (this.Name == word.Name) && (this.Amount == word.Amount);
        }

        public override string ToString()
        {
            return Name + " " + Amount;
        }

    }
}
