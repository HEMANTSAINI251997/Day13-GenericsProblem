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
            int num_one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num_two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int num_three = Convert.ToInt32(Console.ReadLine());

            int val = Maximum.Checkmax(num_one, num_two, num_three);
            Console.WriteLine($"Maximum Number {num_one} , {num_two} & {num_three} = {val}");
        }
    }
}
