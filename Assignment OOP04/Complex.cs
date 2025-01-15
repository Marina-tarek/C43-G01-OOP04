using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP04
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }
        public override string ToString()
        {
            return $"{Real}+{Img}i";
        }
        #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
  ///*Note: Overload the +, - operator to add and subtract two complex numbers.
  public static Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Img = (a?.Img ?? 0) +(b?.Img ?? 0)
            };
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Img = (a?.Img ?? 0) - (b?.Img ?? 0)
            };
        }

        #endregion

    }
}
