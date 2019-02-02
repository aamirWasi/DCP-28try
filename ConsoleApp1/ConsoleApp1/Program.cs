using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                double num1 = double.Parse(space[0]);
                double num2 = double.Parse(space[1]);
                double a = (2 * num1);
                double Dc = Math.Round(a,2);
                double Sc = Math.Round(num2*Math.Round(Math.Sqrt(2),2),2);
                double Ss = Math.Round(Sc);
                if (Dc == Ss)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
