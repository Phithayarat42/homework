using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12_DupNodup
{
    public interface IHomework12
    {
        char FirstDuplicateCharactor(string text);
        char FirstNotDuplicateCharactor(string text);
    }
    class checkChar : IHomework12
    {
        char txt;
        public char FirstDuplicateCharactor(string text)
        {
            string c;

            List<String> word = new List<string>();
            List<String> wordlist = new List<string>();


            for (int i = 0; i < text.Length; i++)
            {
                c = text.Substring(i, 1);
                word.Add(c);
            }

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (word[i] == word[j] && i != j)
                    {
                        wordlist.Add(word[i]);
                        i = text.Length;
                        j = text.Length;
                        break;
                    }
                }
            }
            if (wordlist.Count == 0)
            {
                Console.WriteLine("First duplicate charactor is: -");
            }

            foreach (string i in wordlist)
            {
                Console.WriteLine("First duplicate charactor is: " + i);
            }
            return txt;
        }
        public char FirstNotDuplicateCharactor(string text)
        {
            string c;
            int len = text.Length;
            List<String> word = new List<string>();
            List<String> wordlist = new List<string>();


            for (int i = 0; i < len; i++)
            {
                c = text.Substring(i, 1);
                word.Add(c);
                wordlist.Add(c);
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (word[i] == word[j] && i != j)
                    {
                        wordlist.Remove(word[i]);
                        break;
                    }
                }
            }
            if (wordlist.Count == 0)
            {
                Console.WriteLine("First not duplicate charactor is: -");
            }
            foreach (string i in wordlist)
            {
                Console.WriteLine("First not duplicate charactor is: " + i);
                break;
            }
            Console.WriteLine(" ");
            return txt; ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input string : ");
            string t = Console.ReadLine();

            checkChar check = new checkChar();
            check.FirstDuplicateCharactor(t);
            check.FirstNotDuplicateCharactor(t);
            Console.ReadKey();
        }
    }
}
