using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Circle : Shape
    {
        public double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Perimeter()
        {
            return  (Math.PI * radius) * (Math.PI * radius);
        }
        public override double Area()
        {
            return  Math.PI * radius * radius;
        }
        public override void Print()
        {
            Console.WriteLine("{0}, Area is {1}, Perimeter is {2}", Name, Area(), Perimeter());
        }

    }
}
