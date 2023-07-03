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
            Console.WriteLine("Enter the first words ");
            string num_one = Console.ReadLine();
            Console.WriteLine("Enter the second words");
            string num_two = Console.ReadLine();
            Console.WriteLine("Enter the third words");
            string num_three =Console.ReadLine();

            Maximum maximum = new Maximum();


            string val = maximum.Checkmax(num_one, num_two, num_three);
            Console.WriteLine($"Maximum Number {num_one} , {num_two} & {num_three} = {val}");
        }
    }
}
