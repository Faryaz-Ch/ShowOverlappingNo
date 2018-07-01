using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Paractical1
{
    /// <summary>  
    /// C#  a program that asks the user to enter two lines of comma-separated numbers (data type: double). 
    /// and count the total number of overlapping numbers between the two lines.
    /// Author: Faryaz
    /// </summary> 

    class MainClass
    {
        public static void Main(string[] args)
        {
            ShowOverlappingNo();

        }
        static void ShowOverlappingNo()
        {
            Write("Enter the first line of comma separated numbers: ");
            string line1 = ReadLine(); //input: 1,2,3,4,5,6,7,8,9
            string[] numsAsString1 = line1.Split(','); //split line into array of numeric strings
            Write("Enter the second line of comma separated numbers: ");
            string line2 = ReadLine();
            string[] numsAsString2 = line2.Split(',');
            List<double> group1 = numsAsString1.Select(double.Parse).ToList();
            List<double> group2 = numsAsString2.Select(double.Parse).ToList();

            int count = 0;
            //n1 represents each number in group

            foreach (double n1 in group1)
            {
                foreach (double n2 in group2)

                {

                    if (n1 == n2)
                    {
                        count++;
                    }
                }
            }
            WriteLine($"Intersection count: {count}");

        }
    }
}