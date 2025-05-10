using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Grade = Console.ReadLine();

            int yourGrade = Convert.ToInt32(Grade);

            if (yourGrade >= 90 && yourGrade <= 100)
            {

                Console.WriteLine("A");

            }
            else if (yourGrade >= 80 && yourGrade <= 89)
            {

                Console.WriteLine("B");
            }

            else if (yourGrade >= 70 && yourGrade <= 79)
            {

                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
                   
        } 
           
             
    }
}
