using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 2)
                {
                    string inputFile = args[0];
                    string outputFile = args[1];
                               
                    StreamReader sr = new StreamReader(inputFile);

                    List<Word> selectWords = TextOperations.SelectWords(sr.ReadToEnd());

                    using (StreamWriter sw = File.CreateText(outputFile))
                    {
                        sw.WriteLine(TextOperations.PrintGroup(selectWords));
                    }

                    Console.WriteLine("Операция выполнена успешно. Нажмите любую кнопку ...");
                }
                else
                    {
                    Console.WriteLine("Параметры заданы не корректно.");
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка при выполнении программы:");
                Console.WriteLine(e.Message);
            }
        }
   
    }
}
