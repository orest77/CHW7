using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shape = new List<Shape>();

            for (int i = 0; i < 10; i++)
            {
                if (i >= 5)
                {
                    Console.WriteLine("Enter digit for CIRCLE");
                    float digit = float.Parse(Console.ReadLine());
                    shape.Add(new Circle("Circle", digit));
                }
                else if (i < 5)
                {
                    Console.WriteLine("Enter digit for Square");
                    float digits = float.Parse(Console.ReadLine());
                    shape.Add(new Square("Square ", digits));                   
                }                              
            }

            foreach (var inf in shape)
            {
                //Console.WriteLine(inf.Area());
                //Console.WriteLine(inf.Perimeter());
                inf.Print();
            }

            double largestPerimeter = 0;
            bool first = true;
            string largestPerimeterName = "";
            foreach (var ps in shape)
            {
                if (first)
                {
                    largestPerimeterName = ps.Name;
                    largestPerimeter = ps.Perimeter();
                    first = false;
                }
                else if (ps.Perimeter() > largestPerimeter)
                {
                    largestPerimeterName = ps.Name;
                    largestPerimeter = ps.Perimeter();
                }
            }
            Console.WriteLine("_________________MAX PERIMETER________________");

            Console.WriteLine("{0} {1} has max perimeter", largestPerimeterName, largestPerimeter);
            //sorted by Area

            Console.WriteLine("_________________SORTED BY AREA________________");
            shape.Sort();

            foreach (var ib in shape)
            {
                ib.Print();
            }


            Console.ReadKey();
        }
    }
}
