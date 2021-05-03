using System;
using System.Linq;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
           Start:
            Console.WriteLine("Display n number of triangle areas and their sum:");
            Console.WriteLine("Number of triangles : ");

            var num = Convert.ToInt32(Console.ReadLine());
            if (num < 5)
            {
                Console.WriteLine("Enter a number greater than 5");
                goto Start;
            }
            else
            {
                var Sum = 0;
                for (var x = 0; x < num; x++)
                {
                    //Get Sides Of Triangle
                    Console.WriteLine("The sides of the triangle are : \n");
                    Console.Write("Side A : ");
                    var a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Side B : ");
                    var b = Convert.ToInt32(Console.ReadLine());

                    //Calculate The Area of Each Traingle
                    var result = b * a / 2;
                    Console.Write("Area of Triangle : " + result);

                    //Sum Of All Areas
                    Sum += result;

                    Console.WriteLine("\n The Sum Of All Triangle Areas is : " + Sum);

                }
            }
        }
    }
}

