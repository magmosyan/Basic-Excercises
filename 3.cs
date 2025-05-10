using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String temperature = Console.ReadLine();
            int temperatureNow = Convert.ToInt32(temperature);

            if (temperatureNow < 10)
            {
                Console.WriteLine("Cold");
            }
            else if (temperatureNow >= 10 && temperatureNow <= 20)
            {
                Console.WriteLine("Cool");
            }
            else if (temperatureNow >= 21 && temperatureNow <= 30)
            {
                Console.WriteLine("Warm");
            }
            else
            {
                Console.WriteLine("Hot");
            }

        }
    }
}
