using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Square : Shape
    {
        public double side;

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Perimeter()
        {
            return  4 * side;
        }
        public override double Area()
        {
             return side * side;
        }
        public override void Print()
        {
            Console.WriteLine("{0}, Area is {1}, Perimeter is {2}", Name, Area() , Perimeter());
        }
    }
}
