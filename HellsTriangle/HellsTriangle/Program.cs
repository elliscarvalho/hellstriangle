using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide the length of the triangle and press enter:");
            string lengthStr = Console.ReadLine();
            int length = int.Parse(lengthStr);

            Console.WriteLine("Provide the triangle values separating each line with enter and each element of one row with blank space.");
            int[][] triangle = new int[length][];
            for(int i = 0; i < length; i++)
            {
                triangle[i] = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            }

            Console.WriteLine("Thanks for your information. Getting your answer...");

            var processor = new HellsTriangleProcessor();
            Console.WriteLine("The maximum sum of this triangle is: " + processor.GetMaxTotal(triangle));

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
