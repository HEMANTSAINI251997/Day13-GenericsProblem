using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    public class Program
    {
        static void Main(string[] args)
        {

            Maximum maximum = new Maximum();


            Console.WriteLine("Enter the first Integer Number ");
            int num_one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Integer Number");
            int num_two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Integer Number");
            int num_three = Convert.ToInt32(Console.ReadLine());
          
            int val = maximum.Checkmax<int>(num_one, num_two, num_three);
            Console.WriteLine($"Maximum Number {num_one} , {num_two} & {num_three} = {val}");

            Console.WriteLine("Enter the first Float Number ");
            double num_one_ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second Float Number");
            double num_two_ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third Float Number");
            double num_three_ = Convert.ToDouble(Console.ReadLine());
           
            double val_float = maximum.Checkmax<double>( num_one_, num_two_, num_three_);
            Console.WriteLine($"Maximum Number {num_one_} , {num_two_} & {num_three_} = {val_float}");

            Console.WriteLine("Enter the first word ");
            string word_one = Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string word_two= Console.ReadLine();
            Console.WriteLine("Enter the third word");
            string word_three = Console.ReadLine();
            string value = maximum.Checkmax<string>(word_one , word_two , word_three);

           
            
            Console.WriteLine($"Maximum Number {word_one} , {word_two} & {word_three} = {value}");
        }
    }
}
