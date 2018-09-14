using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    abstract class Shape : IComparable
    {
        protected string name ;
        public string Name { get { return name; } set { name = value; } }

        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        virtual public void Print()
        {
            Console.WriteLine("Name = {0}", name);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Shape otherSHape = (Shape)obj;

            if (otherSHape != null)
            {
                return this.Area().CompareTo(otherSHape.Area());
            }
            else
            {
                throw new FormatException("Not a shape");
            }
        }
    }
}
