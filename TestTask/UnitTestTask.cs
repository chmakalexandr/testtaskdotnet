using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace TestTask
{
    [TestFixture]
    class UnitTestTask
    {
        [Test]
        public void testPrintGroup()
        {
            List<Word> lw1 = new List<Word>();
            Word w1 = new Word();
            w1.Name = "aa";
            w1.Amount = 2;
            lw1.Add(w1);

            Word w2 = new Word();
            w2.Name = "aaa";
            w2.Amount = 1;
            lw1.Add(w2);
           
            Word w3 = new Word();
            w3.Name = "bbb";
            w3.Amount = 1;
            lw1.Add(w3);
           
            Assert.AreEqual("a\r\naa 2\r\naaa 1\r\nb\r\nbbb 1\r\n", TextOperations.PrintGroup(lw1));
            
        }

        [Test]
        public void testSelectWords()
        {
            List<Word> lw = new List<Word>();
            Word w1 = new Word();
            w1.Name = "aa";
            w1.Amount = 2;
            lw.Add(w1);

            Word w2 = new Word();
            w2.Name = "aaa";
            w2.Amount = 1;
            lw.Add(w2);

            Word w3 = new Word();
            w3.Name = "bbb";
            w3.Amount = 1;
            lw.Add(w3);

            List<Word> result = TextOperations.SelectWords("aa aaa bbb aa");
            CollectionAssert.AreEqual(lw,result);

        }
    }
}
