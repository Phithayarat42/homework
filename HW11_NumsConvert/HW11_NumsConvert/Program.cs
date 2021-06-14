using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_NumsConvert
{
    public interface IHomework11
    {
        string GetReadWordOfNumber(int number);
    }
    class numCon : IHomework11 {
        public int GetReadWordOfNumber(int number) {
            string[] thNum = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ", "เอ็ด" };
            string[] thN = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };

            if (number == 0) {
                Console.Write("ศูนย์");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input number: ");
            string sents = Console.ReadLine();
        }
    }
}
