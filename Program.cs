using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOptrEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Enter the First number to compare");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number to compare");
            j = Convert.ToInt32(Console.ReadLine());
            String result = i > j ? "First number is greater than Second number"
                                : i < j ? "First number is less than Second number"
                                    : i == j ? "First number is equal to Second number" : "No result";
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
