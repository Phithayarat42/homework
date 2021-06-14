using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_duplicate
{
    public interface IHomework07
    {
        string RemoveAndSortTextByAlphabetical(string text);
    }

    class RemoveAndSort : IHomework07 {
        //hello world and practice makes perfect and hello world again
        public string RemoveAndSortTextByAlphabetical(string text) {

            string[] word = text.Split(' ');
            Array.Sort(word);
            var noDup = new HashSet<string>(word);

            var noDupText = string.Join(" ", noDup);

            Console.WriteLine(noDupText);

            return null; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your sentent : ");
            string sents = Console.ReadLine();

            RemoveAndSort sentence = new RemoveAndSort();
            sentence.RemoveAndSortTextByAlphabetical(sents);

            Console.ReadKey();
        }
    }
}
