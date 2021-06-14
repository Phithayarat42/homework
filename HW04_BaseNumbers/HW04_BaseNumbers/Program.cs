using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_BaseNumbers
{

    public interface IHomework04
    {
        string GetDivisibleBy5Text(string text);
    }
    class Calculates : IHomework04 {
        public string GetDivisibleBy5Text(string text) {
            
            var nums = text.Split(',');

            var divise5 = new List<int>();

            foreach (var nstr in nums)
            {
                var num = Convert.ToInt32(nstr, 2);

                if (num % 5 == 0)
                {
                    divise5.Add(num);
                    
                }
            }
            Console.WriteLine(string.Join(", ", divise5.Select(x => Convert.ToString(x, 2))));
            return null;
        

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Binary Numbers : ");
            string bins = Console.ReadLine();

            Calculates numbers = new Calculates();
            numbers.GetDivisibleBy5Text(bins);
            Console.ReadKey();
        }
    }
}
