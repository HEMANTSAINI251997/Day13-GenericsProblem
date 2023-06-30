using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number ");
            double num_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num_two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            double num_three = Convert.ToDouble(Console.ReadLine());

            double val = Maximum.Checkmax(num_one, num_two, num_three);
            Console.WriteLine($"Maximum Number {num_one} , {num_two} & {num_three} = {val}");
        }
    }
}
