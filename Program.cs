using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteAverage(2, 7);

        }
        static void WriteAverage (int a, int b)
        {
            Console.WriteLine( (a+b)/ 2.0);


        }

        static void WriteEuropean(string day, int date, string month, int year)
        {
            Console.WriteLine( "{0} { 1} {2], { 3}"); day, date, month, year);

        }

        static void WriteAmerican(string day, int date, string month, int year)

        {
            Console.WriteLine("{0} { 2} {1], { 3}"); day, date, month, year);

        }
    }
}
