using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex;
            char let;
            char[] hexa = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
            double cot = 0, sum = 0;
            Console.Write("Enter a hexadecimal number you wish to convert : ");
            hex = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------");
            for (int i = 0; i < hex.Length; i++)
            {
                let = hex[hex.Length - 1 - i];
                for (int y = 0; y < 16; y++)
                {
                    if (let == hexa[y])
                    {
                        sum += Convert.ToInt64(y) * (Math.Pow(16, cot));
                        cot++;
                    }
                }

            }
            Console.Write("The number in decimal is : " + sum);
            Console.ReadKey();
        }
    }
}

