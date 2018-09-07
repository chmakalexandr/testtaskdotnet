using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTask
{
    class TextOperations
    {
        public static List<Word> SelectWords(string text)
        {
            string strLine = text.ToLower();
            Regex regex = new Regex(@"[^a-z-\s]");
            var strNewLine = regex.Replace(strLine, "");

            String pattern = @"[^\s]+";
            var wordCollection = new List<Word>();

            foreach (Match m in Regex.Matches(strNewLine, pattern))
            {
                Word wrd = new Word();
                wrd.Name = m.Value;
                wrd.Amount = new Regex(@"\b" + wrd.Name + @"\b").Matches(strNewLine).Count;
                wordCollection.Add(wrd);
            }

            var distinctWords = wordCollection.Distinct(new DistinctWordComparer()).ToList();

            return distinctWords;
        }

        public static string PrintGroup(List<Word> distinctWords)
        {
            char firstCharWord = ' ';
            string groups = "";
            distinctWords.Sort();
            foreach (var word in distinctWords)
            {
                string name = word.Name;
                if (name.Substring(0, 1) != firstCharWord.ToString())
                {
                    firstCharWord = name.Substring(0, 1).ToCharArray()[0];
                    Group group = new Group(firstCharWord);
                    var selectedWords = distinctWords.Where(w => w.Name.StartsWith(firstCharWord.ToString())).OrderByDescending(w => w.Amount).ToList();
                    group.Words = selectedWords;
                    groups = groups + group.ToString();
                }
            }
            return groups;
        }
    }
}
