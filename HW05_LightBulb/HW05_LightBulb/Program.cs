using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_LightBulb
{

    public interface IHomework05
    {
        string DisplayLEDOnScreen(string ledNo);
    }
    class Light : IHomework05
    {
        string on = "[!]";
        string off = "[]";
        string lamp;
        public string DisplayLEDOnScreen(string ledNo)
        {
            string[] l = { ledNo  };
            for (int i = 0; i < 11; i++) {
                if (ledNo == "1" ||
                    ledNo == "2" ||
                    ledNo == "3" ||
                    ledNo == "4" ||
                    ledNo == "5" ||
                    ledNo == "6" ||
                    ledNo == "7" ||
                    ledNo == "8" ||
                    ledNo == "9" ||
                    ledNo == "A" ||
                    ledNo == "a") {
                    lamp = on;
                    break;
                }
            }return lamp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\n 1   2   3   4   5   6   7   8   9   A\n");
            string[] led = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"};
            string numled;

            do
            {
                Console.Write("Please choose LED to turn On/Off: ");
                numled = Console.ReadLine();
                Light light = new Light();

                int x;
                if (numled == "1" ||
                    numled == "2" ||
                    numled == "3" ||
                    numled == "4" ||
                    numled == "5" ||
                    numled == "6" ||
                    numled == "7" ||
                    numled == "8" ||
                    numled == "9")
                {
                    x = Convert.ToInt32(numled) - 1;
                    for (int i = 0; i < 10; i++)
                    {
                        if (x == i && led[x] == "[!]")
                        {
                            led[x] = "[ ]";
                            break;
                        }
                        if (x == i)
                        {
                            led[x] = light.DisplayLEDOnScreen(numled);
                            break;
                        }

                    }
                }
                if (numled == "A" || numled == "a")
                {
                    x = 9;
                    for (int i = 0; i < 10; i++)
                    {
                        if (x == i && led[x] == "[!]")
                        {
                            led[x] = "[ ]";
                            break;
                        }
                        if (x == i)
                        {
                            led[x] = light.DisplayLEDOnScreen(numled);
                            break;
                        }
                    }
                }
                foreach (string i in led)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("  \n 1   2   3   4   5   6   7   8   9   A\n  ");

            } while (numled != "stop");
        }
    }
}
