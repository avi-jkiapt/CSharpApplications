using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OveratorOverloading
{
    /*
      Overloaded operators are functions with special names the keyword operator followed
        by the symbol for the operator being defined. Similar to any other function, an 
        overloaded operator has a return type and a parameter list.C# allows user-defined
        types to overload operators by defining static member functions using the operator keyword.

    */
    /*
                access_specifier  className  operator Operator_symbol (parameters)
             {
               // Code
             } 
     */
     class House
    {
        private double length;
        private double bredth;
        private double height;

        public House()
        {
            length = 0.0;
            bredth = 0.0;
            height = 0.0;
        }

        public House(double l,double b, double h)
        {
            length = l;
            bredth = b;
            height = h;

        }

        public  double Volume()
        {
            return length * bredth * height;
        }

        public static House operator +(House a, House b)
        {
            House h = new House();
            h.length = a.length + b.length;
            h.bredth = a.bredth + b.bredth;
            h.height = a.height + b.height;
            return h;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House(10.2, 20, 2.5);
            House h2 = new House(21.1, 21, 30.5);
            House h3 = h1 + h2;
            double h3Volume = h3.Volume();
            Console.WriteLine("Volume of House: {0}", h3Volume);
            Console.ReadKey();
        }
    }
}
