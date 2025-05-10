using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name");
            string name = Console.ReadLine();

            Console.WriteLine("your age");
            String age = Console.ReadLine();
            int yourAge = Convert.ToInt32(age);

            Console.WriteLine("Are you a student? (true/false)");

            bool isStudent = Convert.ToBoolean(Console.ReadLine());
          

            if (isStudent && yourAge < 18)
            {
                Console.WriteLine("Hi " + name + ", you get a 50% student discount");
            }
            else if (isStudent && yourAge >= 18)
            {
                Console.WriteLine("Hi " + name + ", you get a 30% student discount");
            }
            else
            {
                Console.WriteLine("Hi " + name + ", full price applies");
            }
        }
    }
}
