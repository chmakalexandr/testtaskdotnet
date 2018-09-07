using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Group
    {
        public char Name { get; set; }
        public List<Word> Words { get; set; }

        public Group(char name)
        {
            Name = name;
        }

        public override string ToString()
        {
            string output = "";
            output = Name + "\r\n";
            foreach (Word w in Words)
            {
                output = output + w.ToString() + "\r\n";
            }

            return output;
        }
    }
}
